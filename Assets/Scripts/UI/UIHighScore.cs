using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIHighScore : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private HighScore _highScore;
    private int Highscore;

    private void Awake()
    {
        _highScore.GetComponent<HighScore>();
    }

    private void Update()
    {
        Highscore = PlayerPrefs.GetInt(_highScore.highScore);
        print($"Highscore is {Highscore}");
        text.text = $"{Highscore}";
    }
}
