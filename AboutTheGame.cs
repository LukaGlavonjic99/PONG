using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AboutTheGame : MonoBehaviour
{
    public void returnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
