using UnityEngine;

public class ExtraSpawner : MonoBehaviour
{
    [SerializeField] private GiveScore _giveScore;

    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject spawnPoint;
    
    private void Awake()
    {
        _giveScore.GetComponent<GiveScore>();
        _giveScore.scored.AddListener(Spawn);
    }
    
    private void Spawn()
    {
        for (var i = 0; i < 2; i++)
        {
            Instantiate(enemy, spawnPoint.transform.position, Quaternion.identity);
        }
    }
    
}
