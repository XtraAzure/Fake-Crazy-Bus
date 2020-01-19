using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class OptionManager : MonoBehaviour
{
    [SerializeField]
    private Slider BGMSlider;

    [SerializeField]
    private Slider SFXSlider;

    // Start is called before the first frame update
    void Start()
    {
        BGMSlider.value = PlayerPrefsManager.GetBGMVolume();
        SFXSlider.value = PlayerPrefsManager.GetSFXVolume();
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefsManager.SetBGMVolume(BGMSlider.value);
        PlayerPrefsManager.SetSFXVolume(SFXSlider.value);

        if (Input.GetKeyDown(KeyCode.H))
        {
            PlayHorn();
        }
    }

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetBGMVolume(BGMSlider.value);
        PlayerPrefsManager.SetSFXVolume(SFXSlider.value);
        SceneManager.LoadScene("Menu");

    }

    void PlayHorn()
    {
        FindObjectOfType<AudioManager>().Play("Horn");

    }
}
