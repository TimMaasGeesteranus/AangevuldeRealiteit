using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    Dropdown languageDropdown;
    GameObject a;

    List<string> languages = new List<string> { "netherlands", "Englisch", "German" };

    // Start is called before the first frame update
    void Start()
    {
        SetupDropdown();

    }

    private void SetupDropdown()
    {
        languageDropdown.ClearOptions();
        languageDropdown.AddOptions(languages);
        languageDropdown.RefreshShownValue();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
