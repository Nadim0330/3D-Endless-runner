using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public static AudioSource bgAudio;
    public static int Lives;
    public GameObject gameOverScreen,Live1,Live2,Live3;
    public Text scoreText;
    public Text highScoreText;
    public Text newScore;

    public static int score;
    public int highScore;
    public float decimalScore;
    public int pointsPerSecond = 10;

    void Start()
    {
        bgAudio = GetComponent<AudioSource>();
        Lives = 3;
        Live1.SetActive(true);
        Live2.SetActive(true);
        Live3.SetActive(true);
    }

    private void OnClickTryAgain()
    {
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene("gameScene");
    }

    private void IncreaseScore()
    {
        decimalScore += pointsPerSecond * Time.deltaTime;
        score = Mathf.RoundToInt(decimalScore);
        PlayerPrefs.SetInt("newScore", score);
    }
    private void ShowScore() 
    {
        scoreText.text = "Score: " + score;
        newScore.text = "New Score: " + score;
    }

    public void onClickMainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
    void Update()
    {

        if (PlayerPrefs.GetInt("newScore")> PlayerPrefs.GetInt("hiScore"))
        {
           highScore = PlayerPrefs.GetInt("newScore");
           PlayerPrefs.SetInt("hiScore", highScore);
           PlayerPrefs.Save();
        }
        
        else
        {
            if (PlayerPrefs.GetInt("newScore") > highScore)
           {
               highScore = PlayerPrefs.GetInt("newScore");
               PlayerPrefs.SetInt("hiScore", highScore);
               PlayerPrefs.Save();
            }
        }

        highScoreText.text = "High Score:" + highScore;
        ShowScore();
        LivesSystem();
  
    }

    void LivesSystem() 
    {
        if (Lives > 3)
            Lives = 3;
        switch (Lives)
        {
            case 3:
                Live1.SetActive(true);
                Live2.SetActive(true);
                Live3.SetActive(true);
                IncreaseScore();
                break;
            case 2:
                Live1.SetActive(true);
                Live2.SetActive(true);
                Live3.SetActive(false);
                IncreaseScore();
                break;
            case 1:
                Live1.SetActive(true);
                Live2.SetActive(false);
                Live3.SetActive(false);
                IncreaseScore();
                break;
            case 0:
                Live1.SetActive(false);
                Live2.SetActive(false);
                Live3.SetActive(false);
                gameOverScreen.SetActive(true);
                bgAudio.Pause();
                break;
            default:
                Live1.SetActive(false);
                Live2.SetActive(false);
                Live3.SetActive(false);
                gameOverScreen.SetActive(true);
                bgAudio.Pause();
                break;
        }
    }
}
