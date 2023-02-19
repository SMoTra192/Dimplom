using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private EnemyGiveDamage _enemyGiveDamage;
    [SerializeField] private int health;
    public UnityEvent damaged = new();

    private void Awake()
    {
        _enemyGiveDamage.GetComponent<EnemyGiveDamage>();
        _enemyGiveDamage.giveDamage.AddListener(() => TakeDamage(damage:1));
        
        
    }

    private void Update()
    {
        if (health == 0 )
            //died.Invoke();
        print($"Now health is {health}");
        GetHealth();
        
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
    }
    
    public int GetHealth()
    {
        return health;
    }
    
}
