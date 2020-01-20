using Assets.Scripts;
using Assets.Scripts.Services;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeLanguageToEnglish : MonoBehaviour
{
    public Text Title;
    public Text Description;

    public async void OnMouseDown()
    {
        MemoryDataService.Language = "en";
        Title.text = await WikipediaService.GetOpenSearch(Title.text, MemoryDataService.Language);
        Description.text = await WikipediaService.FullSearch(Title.text, MemoryDataService.Language);
    }
}
