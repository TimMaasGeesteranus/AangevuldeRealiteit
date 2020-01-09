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

public class SettingsMenu : MonoBehaviour
{
    // Values
    private string language;
    private float distance = 0;
    private List<string> languages = new List<string>();
    private List<string> languagesShort = new List<string>();

    // Gameobjects
    public Button saveButton;
    public Text distanceAmount;
    public Dropdown languageDropdown;
    public Slider radiusSlider;
    public SVGImage radiusImage;

    // Language select
    IEnumerator languagesCoroutine;
    IEnumerator setupCoroutine;

    LanguageTranslatorService languageTranslatorService;
    private string versionDate = "2018-05-01";

    // Setup methods for the settings menu
    void Start()
    {
        languagesCoroutine = GetLanguages();
        setupCoroutine = SetupMenu();

        StartCoroutine(languagesCoroutine);
        StartCoroutine(setupCoroutine);
    }

    // Changes the radius while moving the slider
    void Update()
    {
        ChangeRadiusVector();
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
        radiusSlider.value = distance / 50;
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
        distance = value * 50;
        distanceAmount.text = $"{distance} M";
    }

    // Saves the settings
    public void SaveSettings()
    {
        MemoryDataService.Distance = distance;
        MemoryDataService.Language = language = languagesShort[languageDropdown.value];
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
        SetupDropdown();
        setupSlider();

    }

    public IEnumerator GetLanguages()
    {
        languageTranslatorService = new LanguageTranslatorService(versionDate);

        while (!languageTranslatorService.Authenticator.CanAuthenticate())
            yield return null;


        languageTranslatorService.ListIdentifiableLanguages(
             callback: (DetailedResponse<IdentifiableLanguages> response, IBMError error) =>
             {
             foreach (var element in response.Result.Languages) {
                 languages.Add(element.Name);
                 languagesShort.Add(element.Language);
             }
        });
    }
}
