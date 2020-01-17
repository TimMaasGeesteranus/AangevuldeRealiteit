﻿using System.Collections.Generic;
using Assets.Scripts.Services;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class SettingsMenu : MonoBehaviour
    {
        // Values
        public string language;
        public float distance = 0;
        public List<string> languages = new List<string> { "Nederlands", "English", "Deutsch" };

        public int DistanceStep = 50;
        public float test = 0;

        // Gameobjects
        public Button saveButton;
        public Text distanceAmount;
        public Dropdown languageDropdown;
        public Slider radiusSlider;
        public SVGImage radiusImage;


        // Setup methods for the settings menu
        void Start()
        {
            SetupInitialSettings();
            SetupDropdown();
            setupSlider();
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
            languageDropdown.value = languages.IndexOf(language);
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
            MemoryDataService.Language = language = languages[languageDropdown.value];
            CloseSettings();
        }

        private void CloseSettings()
        {
            MemoryDataService.DirectSave();
            SceneManager.LoadScene("CameraScene");
        }
    }
}
