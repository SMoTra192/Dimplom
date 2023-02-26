#nullable enable
using TMPro;
using UnityEngine;
public class UICoin : MonoBehaviour
{
    [SerializeField] private GiveCoin _giveCoin = null!;
    [SerializeField] private TextMeshProUGUI[] text = null!;
    private int coinValue;

    
    private void Awake()
    {
        coinValue = _giveCoin.getCoinValue();
        _giveCoin.GetComponent<GiveCoin>();
        
    }

    private void Update()
    {
        coinValue = _giveCoin.getCoinValue();
        CoinToSee();
    }

    private void CoinToSee()
    {
        foreach (var text in text)
        {
            text.text = $"{coinValue}";  
        }
        
    }
}
