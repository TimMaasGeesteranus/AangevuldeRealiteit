using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.TextToSpeech.V1;
using UnityEngine.UI;
using UnityEngine.Android;
    
public class WatsonTTS : MonoBehaviour
{
    public Button PlayButton;
    TextToSpeechService textToSpeechService;
    bool isPlaying = false;
    IEnumerator theCoroutine;
    
    AudioSource MyAudioSource;

    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        Button btn = PlayButton.GetComponent<Button>();
        btn.onClick.AddListener(Wrapper);
    }

    void Update(){
        theCoroutine = MyCoroutine();
    }


    public void Wrapper()
    {
        if (isPlaying)
        {
            isPlaying = false;
            StopCoroutine(theCoroutine);
            MyAudioSource.Stop();
            Debug.Log("Stop the track DJ");
        } else
        {
            isPlaying = true;
            StartCoroutine(theCoroutine);
            Debug.Log("DJ spin that shit");
        }
    }

    public IEnumerator MyCoroutine()
    {
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