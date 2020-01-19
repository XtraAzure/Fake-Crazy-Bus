using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using System;
using UnityEngine.SceneManagement;
public class AudioManager : Singleton<AudioManager>
{
    private string myFirstScene = "Menu";

    public static AudioManager instance;

    public Sound[] sounds;

    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);

        Scene scene = SceneManager.GetActiveScene();
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;

            if (s.source.name == "IntroBGM")
            {
                s.source.volume = PlayerPrefsManager.GetBGMVolume();
                Debug.Log(PlayerPrefsManager.GetBGMVolume());
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
            }
            else if (s.source.name == "Horn")
            {
                s.source.volume = PlayerPrefsManager.GetSFXVolume();
                Debug.Log(PlayerPrefsManager.GetSFXVolume());
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
            }
            else if (s.source.name == "Drive")
            {
                s.source.volume = PlayerPrefsManager.GetSFXVolume();
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
            }
            else
            {
                s.source.volume = s.volume;
                s.source.pitch = s.pitch;
                s.source.loop = s.loop;
            }
        }

        

        if (scene.name == myFirstScene)
        {
            //FindObjectOfType<AudioManager>().Play("IntroBGM");
            Debug.Log(sounds[0].volume);
        }

    }

    private void Update()
    {
        sounds[0].source.volume = PlayerPrefsManager.GetBGMVolume();
        sounds[1].source.volume = PlayerPrefsManager.GetSFXVolume();
        sounds[2].source.volume = PlayerPrefsManager.GetSFXVolume();
    }

    private void Start()
    {
        IntroBGM();
    }

    // Update is called once per frame
    public void Play (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Play();
    }

    public void PlayDelay (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.PlayDelayed(0.1f);
    }

    public bool IsPlaying (string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        return s.source.isPlaying;
    }

    void IntroBGM()
    {
        FindObjectOfType<AudioManager>().Play("IntroBGM");
    }

    
    
}
