using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicMainMenu : MonoBehaviour
{
    [SerializeField] AudioSource mainMenuMusic;

    public void onMusic()
    {
        mainMenuMusic.Play();
    }

    public void offMusic()
    {
        mainMenuMusic.Stop();
    }

}
