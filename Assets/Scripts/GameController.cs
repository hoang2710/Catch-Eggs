using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static TMP_Text ScoreText;
    public static TMP_Text TimerText;
    static int playerScore = 0;
    [SerializeField]
    float timeToPlay = 50;
    public GameObject GameOverPanel;
    bool isGameOver = false;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TMP_Text>();
        TimerText = GameObject.FindGameObjectWithTag("TimerText").GetComponent<TMP_Text>();
        ScoreText.text = "0";
        TimerText.text = timeToPlay.ToString();
        //set value after reset scene
        Time.timeScale = 1;
        playerScore = 0;
    }
    void Update()
    {
        if (timeToPlay <= 0 && !isGameOver)
        {
            GameOver();
            isGameOver = true;
        }
        timeToPlay -= Time.deltaTime;
        TimerText.text = ((int)timeToPlay).ToString();
    }
    public static void GetScore(int score)
    {
        playerScore += score;
        if (playerScore < 0)
        {
            playerScore = 0;
        }

        ScoreText.text = playerScore.ToString();
    }

    public void OnPlayAgainButtonClick()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void GameOver()
    {
        Time.timeScale = 0;
        GameOverPanel.SetActive(true);
        GameObject.FindGameObjectWithTag("Player").SetActive(false);
    }
}
