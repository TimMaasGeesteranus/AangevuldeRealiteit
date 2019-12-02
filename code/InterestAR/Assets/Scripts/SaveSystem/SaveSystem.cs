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

        public static void saveSettings(Settings settings) {
            File.WriteAllText(PerisistencePath, JsonUtility.ToJson(settings));
        }

        public static Settings loadSettings(Settings settings)
        {
            StreamReader reader = new StreamReader(PerisistencePath);
            string json = reader.ReadToEnd();
            return JsonUtility.FromJson<Settings>(json);
        }
    }
}
