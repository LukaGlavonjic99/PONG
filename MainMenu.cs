using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void loadPlay()
    {
        SceneManager.LoadSceneAsync(1);

    }

    public void quitGame()
    {
        Application.Quit();
    }

    public void gameSettings()
    {
        SceneManager.LoadSceneAsync(2);
    }

    public void AboutTheGame()
    {
        SceneManager.LoadSceneAsync(3);
    }
}