using System.IO;
using Assets.Scripts.settings;
using UnityEngine;

namespace Assets.Scripts.Services
{
    static class SaveSystem
    {
        private static string PersistencePath = Path.Combine(Application.persistentDataPath, "settings.json");

        // Saves the userdata to the persistent data directory
        public static void saveSettings(UserData userData)
        {
            File.WriteAllText(PersistencePath, JsonUtility.ToJson(userData));
        }

        // Gets the userdata
        public static UserData loadSettings()
        {
            StreamReader reader = new StreamReader(PersistencePath);
            string json = reader.ReadToEnd();
            return JsonUtility.FromJson<UserData>(json);
        }
    }
}
