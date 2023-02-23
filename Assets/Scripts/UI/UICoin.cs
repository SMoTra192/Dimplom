#nullable enable
using TMPro;
using UnityEngine;
public class UICoin : MonoBehaviour
{
    [SerializeField] private GiveCoin _giveCoin;
    [SerializeField] private TextMeshProUGUI[] text;
    private int coinValue;

    
    private void Awake()
    {
        coinValue = _giveCoin.getCoinValue();
        _giveCoin.GetComponent<GiveCoin>();
        _giveCoin.CoinTaken.AddListener(()=>coinValue = _giveCoin.getCoinValue());
    }

    private void Update()
    {
        
        CoinToSee();
        print($"{coinValue}");
    }

    private void CoinToSee()
    {
        foreach (var text in text)
        {
            text.text = $"{coinValue}";  
        }
        
    }
}
