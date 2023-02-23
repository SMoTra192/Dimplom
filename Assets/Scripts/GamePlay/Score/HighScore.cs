using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    [SerializeField] private GiveScore _giveScore;
    private int score,highScoreValue;
    public string highScore = "HighScore";

    private void Awake()
    {
        _giveScore.GetComponent<GiveScore>();
        
    }

    private void Update()
    {
        score = _giveScore.GetScore();
        if (score > highScoreValue) PlayerPrefs.SetInt(highScore,score);
        highScoreValue = PlayerPrefs.GetInt(highScore);
        print($"highScoreValue is {highScoreValue}");
    }
}
