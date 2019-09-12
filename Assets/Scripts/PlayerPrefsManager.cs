using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour {
    const string MASTER_VOLUME_KEY = "music_volume";
    const string MASTER_SOUND_KEY = "sound_volume";
    public static void SetMasterVolume(float volume)
    {
        if (volume >= 0f && volume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_VOLUME_KEY, volume);
        }
        else
        {
          
        }
    }
    public static float GetMasterVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_VOLUME_KEY);
    }
    public static void SetSoundVolume(float soundVolume)
    {
        if (soundVolume >=0f && soundVolume <= 1f)
        {
            PlayerPrefs.SetFloat(MASTER_SOUND_KEY, soundVolume);
        }
        else
        {

        }
    }
    public static float GetSoundVolume()
    {
        return PlayerPrefs.GetFloat(MASTER_SOUND_KEY);
    }
}
