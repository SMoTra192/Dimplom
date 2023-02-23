using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GiveExtraScore : MonoBehaviour
{
    public UnityEvent extraScored = new();
    [SerializeField] private GiveScore _giveScore;
    [SerializeField] private int extraScoreAmount= 2;
    private int score;
    private void Awake()
    {
        _giveScore.GetComponent<GiveScore>();
        extraScored.AddListener(()=> _giveScore.giveScore(extraScoreAmount));
    }
    
}
