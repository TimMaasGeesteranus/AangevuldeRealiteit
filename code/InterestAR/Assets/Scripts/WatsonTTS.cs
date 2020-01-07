using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.TextToSpeech.V1;
using UnityEngine.UI;


public class WatsonTTS : MonoBehaviour
{
    public Button PlayButton;
    public Text Text;
    TextToSpeechService textToSpeechService;
    bool isPlaying = false;
    IEnumerator theCoroutine;
    AudioSource MyAudioSource;


    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        Button btn = PlayButton.GetComponent<Button>();
        btn.onClick.AddListener(Wrapper);
        Debug.Log("HALLO");
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
        string voice = "en-US_AllisonVoice";
        string text = "Hallo lees deze tekst voor";
        string language = MemoryDataService.Language;

        switch (language)
        {
            case "German":
                voice = "de-DE_BirgitVoice";
                break;
            case "English":
                voice = "en-US_AllisonVoice";
                break;
            case "Spanish":
                voice = "es-ES_EnriqueVoice";
                break;
            case "French":
                voice = "fr-FR_ReneeVoice";
                break;
            case "Italian":
                voice = "it-IT_FrancescaVoice";
                break;
            case "Japanese":
                voice = "ja-JP_EmiVoice";
                break;
           case "Portuguese":
                voice = "pt-BR_IsabelaVoice";
                break;
            default:
                voice = "en-US_AllisonVoice";
                break;
        }

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