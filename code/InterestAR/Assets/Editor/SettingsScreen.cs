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
    public class SettingsScreen : MonoBehaviour
    {
        private SettingsMenu settingsMenu;
        private GameObject settingsMenuObject;
        private Component[] components;


        [SetUp]
        public void Setup()
        {
            settingsMenu = new SettingsMenu();
            settingsMenuObject = new GameObject().AddComponent<SettingsMenu>();

            settingsMenu.saveButton = new GameObject().AddComponent<Button>();
            settingsMenu.distanceAmount = new GameObject().AddComponent<Text>();
            settingsMenu.languageDropdown = new GameObject().AddComponent<Dropdown>();
            settingsMenu.radiusSlider = new GameObject().AddComponent<Slider>();
            settingsMenu.radiusImage = new GameObject().AddComponent<SVGImage>();

            //Scene scene = SceneManager.GetSceneByName("SettingsScreen");
            //components = ui.GetComponentsInChildren(scene);\
            //var ui = SearchGameObject("UI",scene.GetRootGameObjects());

            //settingsMenu.saveButton = (Button)SearchComponents("SaveButton", components);
            //settingsMenu.distanceAmount = (Text)SearchComponents("Label (Distance)", components);
            //settingsMenu.languageDropdown = (Dropdown)SearchComponents("Dropdown", components);
            //settingsMenu.radiusSlider = (Slider)SearchComponents("Slider", components);
            //settingsMenu.radiusImage = (SVGImage) SearchComponents("RadiusImage", components);
        }

        //private static GameObject SearchGameObject(string name, GameObject[] objects)
        //{
        //    GameObject selected = null;
        //    foreach (var gameobject in objects)
        //    {
        //        if (gameobject.name == name)
        //        {
        //            selected = gameobject;
        //            break;
        //        }
        //    }
        //    return selected;
        //}

        //private static Component SearchComponents(string name, Component[] objects)
        //{
        //    Component selected = null;
        //    foreach (var component in objects)
        //    {

        //        if (component.name == name)
        //        {
        //            selected = component;
        //            break;
        //        }
        //    }
        //    return selected;
        //}

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

        [UnityTest]
        public void InitialStateTest()
        {

        }
    }
}
