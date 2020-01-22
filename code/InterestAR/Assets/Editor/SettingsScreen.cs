using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using Assets.Scripts.Services;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class SettingsScreen : MonoBehaviour
    {
        private SettingsMenu settingsMenu;
        private GameObject settingsMenuObject;
        private Component[] components;


        [SetUp]
        public void Setup()
        {
            settingsMenu = new GameObject().AddComponent<SettingsMenu>();

            settingsMenu.saveButton = new GameObject().AddComponent<Button>();
            settingsMenu.distanceAmount = new GameObject().AddComponent<Text>();
            settingsMenu.languageDropdown = new GameObject().AddComponent<Dropdown>();
            settingsMenu.radiusSlider = new GameObject().AddComponent<Slider>();
            settingsMenu.radiusImage = new GameObject().AddComponent<SVGImage>();
        }


        [TearDown]
        public void Teardown()
        {
            DestroyImmediate(settingsMenu);
        }

        // Set slider tests
        [Test]
        public void SetSliderTest()
        {
            int value = 1;
            settingsMenu.SetSlider(value);
            Assert.AreEqual($"{value * settingsMenu.DistanceStep} M", settingsMenu.distanceAmount.text);
        }

    }
}
