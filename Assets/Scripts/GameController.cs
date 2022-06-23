using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    public TMP_Text ScoreText;
    static int playerScore = 0;
    // Start is called before the first frame update
    void Start()
    {
        // ScoreText.text = "";
    }

    private void Update()
    {
        ScoreText.text = playerScore.ToString();
    }
    public static void GetScore(int score)
    {
        playerScore += score;
        
    }

}
