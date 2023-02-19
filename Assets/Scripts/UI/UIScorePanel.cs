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
    [SerializeField] private TextMeshProUGUI text;
    private int score;

    private void Awake()
    {
        _giveScore.GetComponent<GiveScore>();
        _giveScore.scored.AddListener(()=>score = _giveScore.GetScore());
        
    }

    private void Update()
    {
        ScorePanel.transform.position = Player.transform.position + offset;
        text.text = $"{score}";
    }
}
