using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPrefsManager : MonoBehaviour
{
    const string BGM_VOLUME_KEY = "BGMValue";
    const string SFX_VOLUME_KEY = "SFXValue";
    const string HIGH_SCORE_KEY = "HighScore";

    const float MIN_VOLUME = 0f;
    const float MAX_VOLUME = 1f;

    public static void SetBGMVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            Debug.Log("BGM volume set to " + volume);
            PlayerPrefs.SetFloat("BGMValue", volume);
        }
        else
        {
            Debug.LogError("BGM volume is out of range");
        }
    }

    public static float GetBGMVolume()
    {
        return PlayerPrefs.GetFloat(BGM_VOLUME_KEY);
    }

    public static void SetSFXVolume(float volume)
    {
        if (volume >= MIN_VOLUME && volume <= MAX_VOLUME)
        {
            Debug.Log("SFXValue set to " + volume);
            PlayerPrefs.SetFloat("SFXValue", volume);
        }
        else
        {
            Debug.LogError("SFXValue is out of range");
        }
    }
    public static float GetSFXVolume()
    {
        return PlayerPrefs.GetFloat(SFX_VOLUME_KEY);
    }

    public static void SetHighScore(int score)
    {
        
       Debug.Log("High Score set to " + score);
       PlayerPrefs.SetInt("HighScore", score);
      
    }

    public static int GetHighScore()
    {
        return PlayerPrefs.GetInt(HIGH_SCORE_KEY);
    }
}
