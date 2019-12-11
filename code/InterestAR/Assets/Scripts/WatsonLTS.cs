using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.LanguageTranslator.V3;
using IBM.Watson.LanguageTranslator.V3.Model;

public class WatsonLTS : MonoBehaviour
{
    System.Int32 count = 30;
    IEnumerator translatorCoroutine;
    public Button PlayButton;
    LanguageTranslatorService languageTranslatorService;
    DetailedResponse<IdentifiableLanguages> listIdentifiableLanguagesResponse;
    private string versionDate = "2018-05-01";

    // Start is called before the first frame update
    void Start()
    {
        Button btn = PlayButton.GetComponent<Button>();
        btn.onClick.AddListener(Wrapper);
    }

    // Update is called once per frame
    void Update(){
        translatorCoroutine = GetLanguages();
    }

    public void Wrapper(){
        StartCoroutine(translatorCoroutine);
    }

    public IEnumerator GetLanguages()
    {
        
        languageTranslatorService = new LanguageTranslatorService(versionDate);

        while (!languageTranslatorService.Authenticator.CanAuthenticate())
            yield return null;


        languageTranslatorService.ListIdentifiableLanguages(
            callback: (DetailedResponse<IdentifiableLanguages> response, IBMError error) =>
            {
                listIdentifiableLanguagesResponse = response;
                string[] languageList = listIdentifiableLanguagesResponse.Response.Split("}", count , System.StringSplitOptions.RemoveEmptyEntries);
                Debug.Log(listIdentifiableLanguagesResponse.Response);  

            }
        );
    }
}
