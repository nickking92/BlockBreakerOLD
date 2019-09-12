using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour {
    public Slider musicSlider;
    public Slider soundSlider;
    private AudioManager music;

    public LevelManager levelManager;
    // Use this for initialization
    void Start () {
        music = GameObject.FindObjectOfType<AudioManager>();
        musicSlider.value = PlayerPrefsManager.GetMasterVolume();
        soundSlider.value = PlayerPrefsManager.GetSoundVolume();
    }
	
	// Update is called once per frame
	void Update () {
        music.SetMusicVolume(musicSlider.value);
       music.SetSFXVolume(soundSlider.value);
    }
    public void SaveandExit()
    {
        PlayerPrefsManager.SetMasterVolume(musicSlider.value);
       PlayerPrefsManager.SetSoundVolume(soundSlider.value);
    
    }


}
