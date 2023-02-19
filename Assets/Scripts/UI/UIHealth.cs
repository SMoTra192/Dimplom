
using TMPro;
using UnityEngine;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private PlayerHealth _playerHealth;
    private int health;

    
    void Awake()
    {
        _playerHealth.GetComponent<PlayerHealth>();
        
    }

    private void HealthToSee()
    {
        healthText.text = $"{health}";
    }

    private void Update()
    {
        health = _playerHealth.GetHealth();
        HealthToSee();
    }
}
