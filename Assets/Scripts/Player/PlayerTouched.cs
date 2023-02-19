#nullable enable
using UnityEngine;

public class PlayerTouched : MonoBehaviour
{
    [SerializeField] private EnemyGiveDamage _enemyGiveDamage = null!;
    [SerializeField] private GiveCoin _giveCoin = null!;
    [SerializeField] private GiveTime _giveTime=null!;
    [SerializeField] private GiveBoost _giveBoost = null!;
    [SerializeField] private GiveScore _giveScore = null!;
    [SerializeField] private GiveExtraScore _giveExtraScore = null!;
    private void Awake()
    {
        _giveExtraScore.GetComponent<GiveExtraScore>();
        _giveTime.GetComponent<GiveTime>();
        _giveCoin.GetComponent<GiveCoin>();
        _enemyGiveDamage.GetComponent<EnemyGiveDamage>();
        _giveBoost.GetComponent<GiveBoost>();
        _giveScore.GetComponent<GiveScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RedGuy")) _enemyGiveDamage.giveDamage.Invoke();
        if (other.CompareTag("BlueGuy")) _giveScore.scored.Invoke();
        if (other.CompareTag("PurpleGuy")) _giveExtraScore.extraScored.Invoke();
        if (other.CompareTag("Coin")) _giveCoin.CoinTaken.Invoke();
        if (other.CompareTag("TImer")) _giveTime.timePicked.Invoke();
        if(other.CompareTag("Lightning"))_giveBoost.TakenBoost.Invoke();
    }
}
