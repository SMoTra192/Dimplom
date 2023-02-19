using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GiveScore : MonoBehaviour
{
    public UnityEvent scored = new();
    private int score;
    [SerializeField] private int scoreAmount =1;

    private void Awake()
    {
        scored.AddListener(()=>
            giveScore(scoreAmount));
    }

    public int GetScore()
    {
        return score;
    }
    public void giveScore(int score)
    {
        this.score += score;
    }
    
}
