using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GiveExtraScore : GiveScore
{
    public UnityEvent extraScored = new();
    [SerializeField] private int extraScoreAmount= 2;
    private void Start()
    {
        extraScored.AddListener(()=> giveScore(2));
    }
}
