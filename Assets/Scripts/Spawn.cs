using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject olaf;
    public GameObject MetOlaf;
    public int enemyCounter;
    public int MetEnemyCounter;
    private GameObject Player;
    public float Counter;
    public float MetCounter;

    Quaternion enemy_rotation = Quaternion.Euler(0, 0, -90.6f);
    Quaternion enemy_rotation2 = Quaternion.Euler(0, 0, -40);


    void Start()
    {
        StartCoroutine(EnemySpawner());
        StartCoroutine(MetSpawner());
        enemy_rotation = Quaternion.Euler(0, 0, Random.Range(-99, -76));
        enemy_rotation2 = Quaternion.Euler(0, 0, Random.Range(-70, -50));
    }


    void Update()
    {

    }


    IEnumerator EnemySpawner()
    {


        while (true)
        {

            if (Counter < 10 && GameObject.Find("Player") != null)
            {

                Instantiate(olaf, new Vector3(10, Random.Range(4.55f, -2.6f), 7), enemy_rotation); 



                enemyCounter++;
             
                yield return new WaitForSeconds(Counter);
            }
            else yield return null; 


        }
    }
    IEnumerator MetSpawner()
    {


        while (true)
        {

            if (MetEnemyCounter < 100 && GameObject.Find("Player") != null)
            {

                Instantiate(MetOlaf, new Vector3(Random.Range(1, 19), 5, 0), enemy_rotation2);



                MetEnemyCounter++;

                yield return new WaitForSeconds(MetCounter);
            }
            else yield return null;


        }
    }
}