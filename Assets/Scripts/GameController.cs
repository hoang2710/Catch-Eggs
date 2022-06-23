using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public static TMP_Text ScoreText;
    static int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<TMP_Text>();
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

}
