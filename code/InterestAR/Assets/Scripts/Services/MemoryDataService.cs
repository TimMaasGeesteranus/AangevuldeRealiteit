using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryDataService
{
	private const string LANGUAGE = "language";
	private const string DISTANCE = "distance";

	public static string Language { 
		get { return PlayerPrefs.GetString(LANGUAGE, null); } 
		set { PlayerPrefs.SetString(LANGUAGE,value); } 
	}
	public static int Distance { 
		get { return PlayerPrefs.GetInt(DISTANCE, -1); }
		set { PlayerPrefs.SetInt(DISTANCE, value); }
	}

	public static void DirectSave()
	{
		PlayerPrefs.Save();
	}
}
