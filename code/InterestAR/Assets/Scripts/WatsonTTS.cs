﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IBM.Cloud.SDK;
using IBM.Cloud.SDK.Utilities;
using IBM.Watson.TextToSpeech.V1;
using UnityEngine.UI;


public class WatsonTTS : MonoBehaviour
{
    public Button PlayButton;
    public Text Title;
    TextToSpeechService textToSpeechService;
    bool isPlaying = false;
    IEnumerator theCoroutine;
    AudioSource MyAudioSource;

    public Sprite SoundImage;
    public Sprite NoSoundImage;
    Image ImageComponent;


    void Start()
    {
        MyAudioSource = GetComponent<AudioSource>();
        Button btn = PlayButton.GetComponent<Button>();
        btn.onClick.AddListener(Wrapper);
        ImageComponent = GetComponent<Image>();
    }

    void Update()
    {
        theCoroutine = MyCoroutine(); // Coroutines always change and if not defined withing the Update it will be different and cant be started again.
    }


    public void Wrapper()
    {
        if (isPlaying)
        {
            ImageComponent.sprite = SoundImage;
            isPlaying = false;
            MyAudioSource.Stop(); // This stops the audioplayer, StopCoroutine won't work here since this coroutine first has to finish for it to start talking. 
        }
        else
        {
            ImageComponent.sprite = NoSoundImage;
            isPlaying = true;
            StartCoroutine(theCoroutine);
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
            text: Title.text,
            voice: "en-US_AllisonVoice",
            accept: "audio/wav"
        );

        while (synthesizeResponse == null)
        {
            yield return null;
        }
    }
}