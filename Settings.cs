using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
   // [SerializeField] private AudioMixer audioMixer;
    //[SerializeField] private Slider volumeSlider;
    public AudioMixer audioMixer;


    public void setVolume(float volume)
    {
       // float volume= volumeSlider.value;
        audioMixer.SetFloat("Volume",volume);
    }

    public void setFullScreen(bool isFullScreen)
    {
        Screen.fullScreen=isFullScreen;
    }

    public void returnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
