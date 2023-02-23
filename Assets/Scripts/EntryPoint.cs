using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    //[SerializeField] private UIEffectsForGameOver _effects;
    [SerializeField] private UIEndGame _endGame;
    private float time,timeForGameOver;
    public UnityEvent endGamed = new();
    void Awake()
    {
        _timer.GetComponent<Timer>();
        //_effects.GetComponent<UIEffectsForGameOver>();
        _endGame.GetComponent<UIEndGame>();
        _timer.timed.AddListener(() =>
        {
            if (time != timeForGameOver) ;
            //if(time == timeForGameOver) _effects.startEffect();
            
        });
        endGamed.AddListener(endGameCanvas);
        
    }

    private void Update()
    {
        time = _timer.getTimeValue();
        if (time == 0 ) endGamed.Invoke(); 
    }

    private void endGameCanvas()
    {
        _endGame.ShowPanel();
        _endGame.HideObjects();
    }
    
}
