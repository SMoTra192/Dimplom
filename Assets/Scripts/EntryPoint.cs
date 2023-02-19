using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private EnemyGiveDamage _enemyGiveDamage;
    void Awake()
    {
        _playerHealth.GetComponent<PlayerHealth>();
        _enemyGiveDamage.GetComponent<EnemyGiveDamage>();
    }


    
}
