using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnmaster : MonoBehaviour
{
    public GameObject enemyship;
    public GameObject enemyship2;
    public GameObject enemyship3;
    private int enemyCounter;
    private GameObject player;
    private int dice;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator EnemySpawner()
    {
        while (true)
        {
            if (enemyCounter < 5 && (GameObject.Find("Player") != null || GameObject.Find("Player2") != null))
            {
                //Något random villkor
                int maxSpawn = 2;
                int doubleSpawnChance = Random.Range(1, 4);
                if (doubleSpawnChance < 3)
                {
                    maxSpawn = 3;
                }
                for (int i = 0; i < maxSpawn; i++)
                {
                    dice = Random.Range(1, 3);
                    if (dice == 1)
                    {
                        Instantiate(enemyship, new Vector3(Random.Range(-8, 9), 7, 0), Quaternion.identity);
                        enemyCounter++;
                    }
                    else if (dice == 2)
                    {
                        Instantiate(enemyship2, new Vector3(Random.Range(-8, 9), 7, 0), Quaternion.identity);
                        enemyCounter++;
                    }
                }
                int astroidChans = Random.Range(1, 3);
                if (astroidChans == 1)
                {
                    Instantiate(enemyship3, new Vector3(Random.Range(-8, 9), 7, 0), Quaternion.identity);
                }
                //If dice = 1 instantiate enemyship
                //if dice = 2 instantiate enemyship2

                yield return new WaitForSeconds(2);
            }
            else yield return null;
        }
    }

    public void DecreaseEnemyCounter()
    {
        enemyCounter--;
    }
}
