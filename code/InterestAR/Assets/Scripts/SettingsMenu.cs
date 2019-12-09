using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    // Values
    private string language;
    private float distance = 0;
    private List<string> languages = new List<string> { "Nederlands", "Englisch", "Deutsch" };

    // Gameobjects
    public Button saveButton;
    public Text distanceAmount;
    public Dropdown languageDropdown;
    public Slider slider;
    public SVGImage RadiusImage;


    // Start is called before the first frame update
    void Start()
    {
        SetupInitialSettings();
        SetupDropdown();
        setupSlider();
    }

    void Update()
    {
        ChangeRadiusVector();
    }

    private void ChangeRadiusVector()
    {
        float step = 1 + (slider.value / 2);
        RadiusImage.rectTransform.localScale = new Vector2(step, step);
    }

    private void setupSlider()
    {
        slider.value = distance / 50;
    }

    private void SetupInitialSettings()
    {
        distance = MemoryDataService.Distance;
        language = MemoryDataService.Language;
        distanceAmount.text = $"{distance} M";
    }

    private void SetupDropdown()
    {
        languageDropdown.ClearOptions();
        languageDropdown.AddOptions(languages);
        languageDropdown.RefreshShownValue();
        languageDropdown.value = languages.IndexOf(language);
    }


    public void SetSlider(float value)
    {
        distance = value * 50;
        distanceAmount.text = $"{distance} M";
    }


    public void saveSettings()
    {
        MemoryDataService.Distance = distance;
        MemoryDataService.Language = language = languages[languageDropdown.value];
    }
}
