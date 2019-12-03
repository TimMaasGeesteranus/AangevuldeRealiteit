using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    // Values
    private string language;
    private float distance;  
    private List<string> languages = new List<string> { "netherlands", "Englisch", "German" };

    // Gameobjects
    public Button saveButton;
    public Text distanceAmount;
    public Dropdown languageDropdown;

    
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


    public void SetSlider(float value)
    {
        Debug.Log("test");
        Debug.Log(value);
    }

    public void Set()
    {
        
    }
}
