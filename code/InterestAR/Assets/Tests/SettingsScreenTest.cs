using System.Collections;
using Assets.Scripts;
using Assets.Scripts.Services;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class SettingsScreenTest
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

            settingsMenu.radiusSlider.minValue = 1;
            settingsMenu.radiusSlider.maxValue = 20;

            MemoryDataService.Language = "de";
            MemoryDataService.Distance = 1000;
            MemoryDataService.DirectSave();
        }

        [TearDown]
        public void Teardown()
        {
            Object.Destroy(settingsMenu);
        }

        [UnityTest]
        public IEnumerator Awake_WhenInvoked_SetDropdown()
        {
            string expected = "German";

            yield return Wait(2);

            var DropdownValue = settingsMenu.languageDropdown.value;
            Assert.AreEqual(expected, settingsMenu.languageDropdown.options[DropdownValue].text);
        }

        [UnityTest]
        public IEnumerator Awake_WhenInvoked_SetupInitialSettings()
        {
            string expected = "1000 M";

            yield return Wait(2);

            Assert.AreEqual(expected, settingsMenu.distanceAmount.text);
        }

        [UnityTest]
        public IEnumerator Awake_WhenInvoked_SetSlider()
        {
            float expected = 1000 / settingsMenu.DistanceStep;

            yield return Wait(2);

            Assert.AreEqual(expected, settingsMenu.radiusSlider.value);
        }

        public IEnumerator Wait(int seconds)
        {
            yield return new WaitForSeconds(seconds);
        }
    }
}
