using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
using UnityEngine.UI;

public class GameplayManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    private int currentScore;

    public string player_string = "10";
    public int player_int = 10;


    public void UpdateScore(int score)
    {
        currentScore += score;
        scoreText.text = "Score: " + currentScore.ToString();
    }
    public void StringToInt()
    {
        //convert a string to int: player_string="10" -> player_string=10
        //use: int.TryParse(string, out integer);
        int.TryParse(player_string, out int guess);
        if (guess == player_int)
        {
            Debug.Log("You win " + guess + " points.");
        }
    }
}
