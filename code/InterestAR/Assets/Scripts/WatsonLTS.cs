using System.Collections;
using IBM.Cloud.SDK;
using IBM.Watson.LanguageTranslator.V3;
using IBM.Watson.LanguageTranslator.V3.Model;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class WatsonLTS : MonoBehaviour
    {
        IEnumerator translatorCoroutine;
        public Button PlayButton;
        LanguageTranslatorService languageTranslatorService;
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
                    Debug.Log($"LanguageTranslatorServiceV3 ListIdentifiableLanguages result: {response.Response}");
                    //listIdentifiableLanguagesResponse = response.Result;
                }
            );
        }
    }
}
