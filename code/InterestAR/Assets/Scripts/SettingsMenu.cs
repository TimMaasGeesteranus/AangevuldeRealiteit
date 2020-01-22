using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.LanguageTranslator.V3;
using IBM.Watson.LanguageTranslator.V3.Model;
using System.Threading.Tasks;
using System.Linq;
using Assets.Scripts.Services;
using IBM.Cloud.SDK.Authentication.Iam;

public class SettingsMenu : MonoBehaviour
{
    // Values
    private string language;
    private static float distance = 0;
    private List<string> languages = new List<string>();
    private List<string> languagesShort = new List<string>();

    // Language select
    private IEnumerator languagesCoroutine;
    private IEnumerator setupCoroutine;

    private LanguageTranslatorService languageTranslatorService;
    private string versionDate = "2018-05-01";
    private IamAuthenticator authenticator;

    // Gameobjects
    public Button saveButton;
    public Text distanceAmount;
    public Dropdown languageDropdown;
    public Slider radiusSlider;
    public SVGImage radiusImage;
    public int DistanceStep = 50;

    // Setup methods for the settings menu
    void Start()
    {
        authenticator = new IamAuthenticator("zHZnKAxIRAsSBbW5nGGOrtiOCMX6Nw8tnjqhjPHtiHSl");

        languagesCoroutine = GetLanguages();
        setupCoroutine = SetupMenu();

        StartCoroutine(languagesCoroutine);
        StartCoroutine(setupCoroutine);
    }

    // Changes the radius while moving the slider
    void Update()
    {
        ChangeRadiusVector();
        Debug.Log(distance);
    }

    private void ChangeRadiusVector()
    {
        // Changes the scale of the circel vector
        float step = 1 + (radiusSlider.value / 2);
        radiusImage.rectTransform.localScale = new Vector2(step, step);
    }

    // Retrieves the values from the memory
    private void setupSlider()
    {
        radiusSlider.value = distance / DistanceStep;
    }

    // Retrieves the values from the memory
    private void SetupInitialSettings()
    {
        distance = MemoryDataService.Distance;
        language = MemoryDataService.Language;
        distanceAmount.text = $"{distance} M";
    }

    // Setup for the dropdown
    private void SetupDropdown()
    {
        languageDropdown.ClearOptions();
        languageDropdown.AddOptions(languages);
        languageDropdown.RefreshShownValue();

        languageDropdown.value = languagesShort.FindIndex(a => a == language);
    }

    // Sets the slider and current text value
    public void SetSlider(float value)
    {
        distance = value * DistanceStep;
        distanceAmount.text = $"{distance} M";
    }

    // Saves the settings
    public void SaveSettings()
    {
        MemoryDataService.Distance = distance;
        MemoryDataService.Language = language = languagesShort[languageDropdown.value];
        MemoryDataService.DirectSave();
        CloseSettings();
    }

    private void CloseSettings()
    {
        SceneManager.LoadScene("CameraScene");
    }

    public IEnumerator Wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

    public IEnumerator SetupMenu()
    {
        yield return new WaitForSeconds(2);

        SetupInitialSettings();
        setupSlider();
        SetupDropdown();
    }

    public IEnumerator GetLanguages()
    {
        while (!authenticator.CanAuthenticate())
            yield return null;

        languageTranslatorService = new LanguageTranslatorService(versionDate, authenticator);
        languageTranslatorService.SetServiceUrl("https://gateway-lon.watsonplatform.net/language-translator/api");

        languageTranslatorService.ListIdentifiableLanguages(
             callback: (DetailedResponse<IdentifiableLanguages> response, IBMError error) =>
             {

                 if (error != null)
                 {
                     return;
                 }

                 foreach (var element in response.Result.Languages)
                 {
                     languages.Add(element.Name);
                     languagesShort.Add(element.Language);
                 }
             });
    }
}
