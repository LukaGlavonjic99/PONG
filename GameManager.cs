
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _computerScore;
    public Lopta ball;
    public Text skorLevogIgracaText;
    public Text skorDesnogIgracaText;
    public Reket leviReket;
    public Reket desniReket;
    



    public GameObject gameOverMenu;
    public bool isOver;


    private void Start()
    {
        gameOverMenu.SetActive(false);
    }

    private void Update()
    {
        if(_playerScore==5 || _computerScore == 5)
        {
            GameOver();
        }
    }

    public void playerScores()
    {
        _playerScore++;
        this.skorLevogIgracaText.text=_playerScore.ToString();
        this.leviReket.ResetPosition();
        this.desniReket.ResetPosition();
        this.ball.resetPosition();
        this.ball.AddStartingForce();
        
    }

    public void computerScores()
    {
        _computerScore++;
        this.skorDesnogIgracaText.text= _computerScore.ToString();
        this.leviReket.ResetPosition();
        this.desniReket.ResetPosition();
        this.ball.resetPosition();
        this.ball.AddStartingForce();
        
    }

    public void GameOver()
    {
        gameOverMenu.SetActive(true);
        Time.timeScale = 0f;
        isOver = true;
    }

    public void goToMainMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene(0);
    }

    public void restartGame()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    
}
