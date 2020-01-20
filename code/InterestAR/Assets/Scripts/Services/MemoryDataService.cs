using UnityEngine;

namespace Assets.Scripts.Services
{
    public class MemoryDataService
    {
        private const string LANGUAGE = "language";
        private const string DISTANCE = "distance";

        public static string Language
        {
            get { return PlayerPrefs.GetString(LANGUAGE, "en"); }
            set { PlayerPrefs.SetString(LANGUAGE, value); }
        }
        public static float Distance
        {
            get { return PlayerPrefs.GetFloat(DISTANCE, 50); }
            set { PlayerPrefs.SetFloat(DISTANCE, value); }
        }

        public static void DirectSave()
        {
            PlayerPrefs.Save();
        }

        public static void ClearData()
        {
            PlayerPrefs.DeleteAll();
        }
    }
}