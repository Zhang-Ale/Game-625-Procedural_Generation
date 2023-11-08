using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public int score = 100;
    private GameplayManager gameplayManager;

    private void Awake()
    {
        gameplayManager = GameObject.FindObjectOfType <GameplayManager>();

    }
    void OnCollisionEnter2D (Collision2D collision)
    {
        gameplayManager.UpdateScore(score);

    }
}
