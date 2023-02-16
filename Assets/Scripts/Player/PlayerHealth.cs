using System;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health,damage;
    public UnityEvent died = new();
    public UnityEvent damaged = new();

    

    private void Update()
    {
        if (health == 0 )
            died.Invoke();
    }
    private void TakeDamage(int damage)
    {
        died.Invoke();
        health -= damage;
    }

    
    private void OnTriggerEnter(Collider other)
    {
        TakeDamage(damage);
        damaged.Invoke();
    }
}
