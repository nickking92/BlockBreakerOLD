using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class AudioManager: MonoBehaviour
{
    private AudioSource Sfx;
    private AudioSource Music;

    public AudioClip startClip;
    public AudioClip gameClip;

    public AudioMixer AudioMixerGroup;
    static AudioManager instance = null;

    void Awake()

    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this; //ako je preuzeta ne ovo ne unistavaj

            GameObject.DontDestroyOnLoad(gameObject);//uzima instancu game object i postarace se da ne unisti kad se pokrene
        }

        if (Sfx == null || Music == null)
        {
            GetReferencesAndSetVolume();
        }
    }


    private void GetReferencesAndSetVolume()
    {
        Music = transform.GetChild(0).GetComponent<AudioSource>();
        Sfx = transform.GetChild(1).GetComponent<AudioSource>();
        AudioMixerGroup.SetFloat("Music", PlayerPrefsManager.GetMasterVolume());
        AudioMixerGroup.SetFloat("Sfx", PlayerPrefsManager.GetSoundVolume());
    }


    private void OnEnable()  //this method is required to replace OnLevelWasLoaded().
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // subscribe
    }
    private void OnDisable()  //this method is required to replace OnLevelWasLoaded().
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; //unsubscribe
    }
    private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
    {

        // Audio = GetComponent<AudioSource>();
        if (scene.name == "MainMenu")  //switched to scene.name since the previous methodology didn't work. 
        {

            if (!Music.isPlaying || Music.clip != startClip)
            {

                Music.clip = startClip;
                Music.loop = true;
                Music.Play();
            }
        }
        if (scene.name == "Level1")  //switched to scene.name since the previous methodology didn't work. 
        {

            if (!Music.isPlaying || Music.clip != gameClip)
            {

                Music.clip = gameClip;
                Music.loop = true;
                Music.Play();
            }
        }
    }

    public void SetMusicVolume(float volume)
    {
        AudioMixerGroup.SetFloat("Music", Mathf.Log(volume) * 20);
    }
    public void SetSFXVolume(float volume)
    {

        AudioMixerGroup.SetFloat("Sfx", Mathf.Log(volume) * 20);
    }
}






