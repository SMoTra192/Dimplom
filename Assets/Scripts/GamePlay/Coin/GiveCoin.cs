using System;
using UnityEngine;
using UnityEngine.Events;
using Random = UnityEngine.Random;


public class GiveCoin : MonoBehaviour
{
    public UnityEvent CoinTaken = new();
    [SerializeField] private int minValueCoin, maxValueCoin;
    private int coin;
    public string coinString = "Coin";
        private void Awake()
        {
            coin = PlayerPrefs.GetInt(coinString);
            CoinTaken.AddListener(()=>
            {
                
                int coinValue = Random.Range(minValueCoin, maxValueCoin);
                PlayerPrefs.SetInt(coinString,coin + coinValue);
                coin = PlayerPrefs.GetInt(coinString);
            });
        }

    
    public int getCoinValue()
    {
        return coin;
    }
    
}
