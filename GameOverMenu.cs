using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour

 
{
    public GameObject gameOverMenu;
    public bool isOver;

    // Start is called before the first frame update
    void Start()
    {
        gameOverMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void goToMainMenu()
    {
        Time.timeScale= 1f;
        SceneManager.LoadScene(0);
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

  
}
