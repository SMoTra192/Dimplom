using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private Timer _timer;
    
    [SerializeField] private UIEndGame _endGame;
    [SerializeField] private GameObject timer;
    private float time,timeForGameOver;
    public UnityEvent endGamed = new();
    private bool isReadyTostart = false,started = false;
    void Awake()
    {
        
        _timer.GetComponent<Timer>();
        //_effects.GetComponent<UIEffectsForGameOver>();
        _endGame.GetComponent<UIEndGame>();
        _timer.timed.AddListener(() =>
        {
            //if (time != timeForGameOver) ;
            //if(time == timeForGameOver) _effects.startEffect();
            
        });
        endGamed.AddListener(endGameCanvas);
        
    }
    

    private void Update()
    {
        time = _timer.getTimeValue();
        if (timer.activeInHierarchy)
        {
            if (started == false)
            {
                started = true;
                StartCoroutine(wait());
            }
            if(isReadyTostart == true) if (time < 1f ) endGamed?.Invoke();
        }
            

    }

    private void endGameCanvas()
    {
        _endGame.ShowPanel();
        _endGame.HideObjects();
    }

    private IEnumerator wait()
    {
        yield return new WaitForSeconds(3f);
        isReadyTostart = true;

    }
}
