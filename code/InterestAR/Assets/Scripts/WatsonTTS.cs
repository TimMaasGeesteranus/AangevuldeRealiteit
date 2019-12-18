﻿using System.Collections;
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
        public Button PlayButton;
        TextToSpeechService textToSpeechService;
        bool isPlaying = false;
        IEnumerator theCoroutine;
        AudioSource MyAudioSource;

    public void playText()
    {
        //Wrapper();
    }


        void Start()
        {
            ImageComponent.sprite = SoundImage;
            isPlaying = false;
            MyAudioSource.Stop(); // This stops the audioplayer, StopCoroutine won't work here since this coroutine first has to finish for it to start talking. 
        }

        void Update()
        {
            ImageComponent.sprite = NoSoundImage;
            isPlaying = true;
            StartCoroutine(theCoroutine);
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
                text: "In the midst of chaos, there is also opportunity.",
                voice: "en-US_AllisonVoice",
                accept: "audio/wav"
            );

            while (synthesizeResponse == null)
            {
                yield return null;
            }
        }
    }
}