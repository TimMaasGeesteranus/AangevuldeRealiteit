using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.TextToSpeech.V1;

public class WatsonTTS : MonoBehaviour
{
    TextToSpeechService textToSpeechService;


    public void Wrapper(){
        StartCoroutine(Speak());
    }

    public IEnumerator Speak()
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
            text: "Hello world",
            voice: "en-US_AllisonVoice",
            accept: "audio/wav"
        );

        while (synthesizeResponse == null)
        {
            yield return null;
        }
    }
}
