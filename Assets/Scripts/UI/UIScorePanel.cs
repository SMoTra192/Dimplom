using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIScorePanel : MonoBehaviour
{
    [SerializeField] private GiveScore _giveScore;
    [SerializeField] private GameObject ScorePanel,Player;
    [SerializeField] private Vector3 offset;
    [SerializeField] private TextMeshProUGUI[] text;
    private int score;

    private void Awake()
    {
        _giveScore.GetComponent<GiveScore>();
        //_giveScore.scored.AddListener(()=>);
        
    }

    private void Update()
    {
        score = _giveScore.GetScore();
        ScorePanel.transform.position = Player.transform.position + offset;
        foreach (var text in text)
        {
            text.text = $"{score}";  
        }
        
    }
}
