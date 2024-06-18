using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicInGame : MonoBehaviour
{
    [SerializeField] AudioSource inGameMusic;

    public void onMusic()
    {
        inGameMusic.Play();
    }

    public void offMusic()
    {
        inGameMusic.Stop();
    }

}
