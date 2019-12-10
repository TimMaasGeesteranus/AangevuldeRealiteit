using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryDataService
{
    private const string LANGUAGE = "language";
    private const string DISTANCE = "distance";

    public static string Language
    {
        get { return PlayerPrefs.GetString(LANGUAGE, "English"); }
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
}
