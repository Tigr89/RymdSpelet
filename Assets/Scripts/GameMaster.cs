using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour
{
    int GameTimer = 0;
    public int SpawnIntervalMax = 900;
    int SpawnInterval = 180;
    public int WavesBetweenBatch = 1;

    public GameObject EnemyGeneric;
    public GameObject EnemyFast;
    public GameObject EnemySlow;

    public GameObject PowerUp;


    void Start()
    {
        WavesBetweenBatch = WavesBetweenBatch + 1;
    }

    void FixedUpdate()
    {
        GameTimer = GameTimer + 1;
        SpawnInterval = SpawnInterval - 1;
        
        if (SpawnInterval <= 0 )
        {
            if (int.TryParse("" + Mathf.Floor(GameTimer / SpawnIntervalMax), out int i) == true)
            {
                int TryForPowerUp = i;

                for (int ii = 0; ii < TryForPowerUp; ii++)
                {
                    float randomSpawnChance = Random.Range(0.0f, 1.0f);

                    if (randomSpawnChance >= 0.8f)
                    {
                        float randomSpawn = Random.Range(-8.5f, 8.5f);
                        Instantiate(PowerUp, new Vector3(randomSpawn, 5f, 0f), transform.rotation);
                    }
                }
            }

            // Batch 1.
            if (GameTimer >= 0)
            {
                float randomSpawn = Random.Range(-8.5f, 8.5f);
                Instantiate(EnemyGeneric, new Vector3(randomSpawn, 5f, 0f), transform.rotation);
            }
            // Batch 2.
            if (GameTimer >= (SpawnIntervalMax * WavesBetweenBatch * 1))
            {
                float randomSpawn = Random.Range(-8.5f, 8.5f);
                Instantiate(EnemySlow, new Vector3(randomSpawn, 5f, 0f), transform.rotation);
            }
            // Batch 3.
            if (GameTimer >= (SpawnIntervalMax * WavesBetweenBatch * 2))
            {
                float randomSpawn = Random.Range(-8.5f, 8.5f);
                Instantiate(EnemyFast, new Vector3(randomSpawn, 5f, 0f), transform.rotation);
            }
            // Batch 4.
            if (GameTimer >= (SpawnIntervalMax * WavesBetweenBatch * 1))
            {
                float randomSpawn = Random.Range(-8.5f, 8.5f);
                Instantiate(EnemySlow, new Vector3(randomSpawn, 5f, 0f), transform.rotation);
            }


            SpawnInterval = SpawnIntervalMax;
        }
    }
}
