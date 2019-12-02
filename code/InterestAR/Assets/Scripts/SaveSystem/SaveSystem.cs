using Assets.Scripts.settings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.SaveSystem
{
    static class SaveSystem
    {
        private static string PerisistencePath = Path.Combine(Application.persistentDataPath, "settings.json");

        // Saves the userdata to the persistent data directory
        public static void saveSettings(UserData userData) {
            File.WriteAllText(PerisistencePath, JsonUtility.ToJson(userData));
        }

        // Gets the userdata
        public static UserData loadSettings()
        {
            StreamReader reader = new StreamReader(PerisistencePath);
            string json = reader.ReadToEnd();
            return JsonUtility.FromJson<UserData>(json);
        }
    }
}
