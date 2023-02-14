using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject[] enemy;
    [SerializeField] private GameObject[] spawnPoint;
    private int randPosition,randEnemy;
    public float startTimeBtwSpawns;
    private float timeBtwSpawns;

    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }


    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            
            for (var i = 0; i < 2; i++)
            {
                randPosition = Random.Range(0, spawnPoint.Length);
                randEnemy = Random.Range(0, enemy.Length);
                Instantiate(enemy[randEnemy], spawnPoint[randPosition].transform.position, Quaternion.identity);
            }
            timeBtwSpawns = startTimeBtwSpawns;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }

    }
}