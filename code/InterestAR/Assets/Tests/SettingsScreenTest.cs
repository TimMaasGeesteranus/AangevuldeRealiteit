using System.Collections;
using System.Collections.Generic;
using Assets.Scripts;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

namespace Tests
{
    public class SettingsScreenTest
    {
        private SettingsMenu settingsMenu;
        GameObject[] gameObjects;


        [SetUp]
        public void Setup()
        {
            Scene s = SceneManager.GetSceneByName("SettingsScreen");
            GameObject[] gameObjects = s.GetRootGameObjects();

            Debug.Log(gameObjects.Length);

            settingsMenu = new SettingsMenu();
            //settingsMenu.saveButton = new Button();

            //GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
            //List<GameObject> objList = GameObjectEventsHandler.specificSceneObjects["your scene you want"];

            //MonoBehaviour.Instantiate(Resources.Load<GameObject>("Prefabs/Game"));

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
            Assert.AreEqual(-1, gameObjects.Length);
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
