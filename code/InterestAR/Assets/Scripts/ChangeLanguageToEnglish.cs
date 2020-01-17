using Assets.Scripts;
using Assets.Scripts.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguageToEnglish : MonoBehaviour
{
    public Text ChangingText;
    public Text ChangingTitle;

    public async void OnMouseDown()
    {
        MemoryDataService.Language = "en";
        ChangingText.text = await InsertTextFromAPI.fullSearch("Eiffel Tower", MemoryDataService.Language);
        ChangingTitle.text = await InsertTextFromAPI.GetOpenSearch("Eiffel Tower", MemoryDataService.Language);
    }
}
