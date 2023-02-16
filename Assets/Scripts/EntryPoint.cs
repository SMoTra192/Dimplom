using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPoint : MonoBehaviour
{
    [SerializeField] private PlayerHealth _playerHealth;



    // Start is called before the first frame update
    void Start()
    {
        _playerHealth.GetComponent<PlayerHealth>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
