using UnityEngine;

public class EnemyPoof : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}


    
        
    

