using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{                                   
    public static Score instance; 
    public Text scoreText;
    public Text winText;
    public int score;
    public int winAmount = 5;

    void Awake() //before start 
    {
        if (instance == null) 
        {
            instance = this;
        }
        else //we already have a score instance in this game, so we want to destroy this one because we don't ever want more than 2
        {
            Destroy(this);
        }
    }

    void Start()
    {
        updateScoreText();
    }

    public void increaseScore(int amount)
    {
        score += amount;
        updateScoreText();

        if (score >= winAmount)
        {
            winText.gameObject.SetActive(true);
        }
    }

    void updateScoreText()
    {
        scoreText.text = score.ToString();
    }
}

