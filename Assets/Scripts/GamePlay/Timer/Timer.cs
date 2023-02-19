using System;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    private float _timer;
    public float _timerduration = 3f * 60f;
    [SerializeField]private TextMeshProUGUI _firstminute;
    [SerializeField]private TextMeshProUGUI _secondminute;
    [SerializeField]private TextMeshProUGUI _separator;
    [SerializeField]private TextMeshProUGUI _fisrtsecond;
    [SerializeField]private TextMeshProUGUI _secondsecond;
    [SerializeField] private GiveTime _giveTime;
    private float takenTime;

    private void Awake()
    {
        _giveTime.GetComponent<GiveTime>();
        _giveTime.timePicked.AddListener(getTime);
    }

    void Start()
    {
        ResetTimer();
        takenTime = _giveTime.getTimeValue();
    }
    private void ResetTimer()
    {
        _timer = _timerduration;
    }

    private void Update()
    {
        if (_timer > 0)
        {
            _timer -= Time.deltaTime;
            UpdateDisplay(_timer);
        }
    }

    private void UpdateDisplay(float time)
    {
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);
        string currenttime = string.Format("{00:00}{1:00}", minutes, seconds);
        _firstminute.text = currenttime[0].ToString();
        _secondminute.text = currenttime[1].ToString();
        _fisrtsecond.text = currenttime[2].ToString();
        _secondsecond.text = currenttime[3].ToString();
        
    }

    private void getTime()
    {
        _timer += takenTime;
    }
}
