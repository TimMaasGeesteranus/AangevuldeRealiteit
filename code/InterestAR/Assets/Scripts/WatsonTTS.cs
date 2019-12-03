using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.TextToSpeech.V1;
using IBM.Watson.LanguageTranslator.V3;
using UnityEngine.UI;
using IBM.Watson.LanguageTranslator.V3.Model;

public class WatsonTTS : MonoBehaviour
{
    public Button PlayButton;
    TextToSpeechService textToSpeechService;
    bool isPlaying = false;
    IEnumerator theCoroutine;
    AudioSource MyAudioSource;

    LanguageTranslatorService languageTranslatorService;
    private string versionDate = "2018-05-01";

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


    public void Wrapper()
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

    public IEnumerator MyCoroutine()
    {
        textToSpeechService = new TextToSpeechService();

        while (!textToSpeechService.Authenticator.CanAuthenticate())
            yield return null;

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

            text: "blaf blaf blaf blaf. blaf blaf blaf blaf. blaf blaf blaf blaf",
            voice: "en-US_AllisonVoice",
            accept: "audio/wav"
        );

        while (synthesizeResponse == null)
        {
            yield return null;
        }
    }
}