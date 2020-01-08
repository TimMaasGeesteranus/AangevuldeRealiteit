using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.TextToSpeech.V1;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class WatsonTTS : MonoBehaviour
    {
        public GameObject ObjectToToggle;
        public Button PlayButton;
        public Text Text;
        public GameObject script;
        TextToSpeechService textToSpeechService;
        bool isPlaying = false;
        IEnumerator theCoroutine;
        AudioSource MyAudioSource;
        string voice;


        void Start()
        {
            MyAudioSource = GetComponent<AudioSource>();
            Button btn = PlayButton.GetComponent<Button>();
            btn.onClick.AddListener(Wrapper);
        }

        void Update()
        {
            theCoroutine = MyCoroutine(); // Coroutines always change and if not defined withing the Update it will be different and cant be started again.
        }

        public bool checkIfLanguageIsSupported()
        {
            string language = MemoryDataService.Language;

            switch (language)
            {
                case "de":
                    voice = "de-DE_BirgitVoice";
                    break;
                case "en":
                    voice = "en-US_AllisonVoice";
                    break;
                case "es":
                    voice = "es-ES_EnriqueVoice";
                    break;
                case "fr":
                    voice = "fr-FR_ReneeVoice";
                    break;
                case "it":
                    voice = "it-IT_FrancescaVoice";
                    break;
                case "ja":
                    voice = "ja-JP_EmiVoice";
                    break;
                case "pt":
                    voice = "pt-BR_IsabelaVoice";
                    break;
                default:
                    Debug.Log("This language is not supported ): ");
                    if (ObjectToToggle != null)
                    {
                        ObjectToToggle.SetActive(!ObjectToToggle.activeSelf);
                    }
                    return false;
            }
            return true;
        }

        public void Wrapper()
        {
            if (checkIfLanguageIsSupported() == true)
            {
                if (isPlaying)
                {
                    isPlaying = false;
                    MyAudioSource.Stop(); // This stops the audioplayer, StopCoroutine won't work here since this coroutine first has to finish for it to start talking. 
                }
                else
                {
                    isPlaying = true;
                    StartCoroutine(theCoroutine);
                }
            }
        }

        public IEnumerator MyCoroutine()
        {
            string text = "Hallo lees deze tekst voor";

            textToSpeechService = new TextToSpeechService();

            while (!textToSpeechService.Authenticator.CanAuthenticate())
                yield return null;

            byte[] synthesizeResponse = null;
            AudioClip clip = null;
            textToSpeechService.Synthesize(
                callback: (DetailedResponse<byte[]> response, IBMError error) =>
                {
                    synthesizeResponse = response.Result;
                    clip = WaveFile.ParseWAV("hello_world.wav", synthesizeResponse);
                    AudioSource audioSource = GetComponent<AudioSource>();
                audioSource.clip = clip;
                    audioSource.Play();
                },
                text: text,
                voice: voice,
                accept: "audio/wav"
            );

            while (synthesizeResponse == null)
            {
                yield return null;
            }
        }
    }
}