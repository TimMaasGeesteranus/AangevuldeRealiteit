using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;
using UnityEngine.UI;

namespace Tests
{
    public class SettingsScreen
    {
        private SettingsMenu settingsMenu;
        private Component[] components;


        [SetUp]
        public void Setup()
        {
            settingsMenu = new SettingsMenu();
            Scene scene = SceneManager.GetSceneByName("SettingsScreen");

            var ui = SearchGameObject("UI",scene.GetRootGameObjects());
            components = ui.GetComponentsInChildren(GetType());

            settingsMenu.saveButton = (Button)SearchComponents("SaveButton", components);
            settingsMenu.distanceAmount = (Text)SearchComponents("Label (Distance)", components);
            settingsMenu.languageDropdown = (Dropdown)SearchComponents("Dropdown", components);
            settingsMenu.radiusSlider = (Slider)SearchComponents("Slider", components);
            settingsMenu.radiusImage = (SVGImage) SearchComponents("RadiusImage", components);
        }

        private static GameObject SearchGameObject(string name, GameObject[] objects)
        {
            GameObject selected = null;
            foreach (var gameobject in objects)
            {
                if (gameobject.name == name)
                {
                    selected = gameobject;
                    break;
                }
            }
            return selected;
        }

        private static Component SearchComponents(string name, Component[] objects)
        {
            Component selected = null;
            foreach (var component in objects)
            {

                if (component.name == name)
                {
                    selected = component;
                    break;
                }
            }
            return selected;
        }

        [TearDown]
        public void Teardown()
        {
            Object.Destroy(settingsMenu);
        }

        // A Test behaves as an ordinary method
        [Test]
        public void SettingsScreenTestSimplePasses()
        {
           
        }


        [Test]
        public IEnumerator SettingsScreenTestWithEnumeratorPasses()
        {
            // Use the Assert class to test conditions.
            // Use yield to skip a frame.
            yield return null;
        }
    }
}
