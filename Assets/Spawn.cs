using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject olaf;
    private int enemyCounter;
    private GameObject Player;
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }


    void Update()
    {

    }


    IEnumerator EnemySpawner()
    {


        while (true)
        {

            if (enemyCounter < 10 && GameObject.Find("Player") != null)
            {

                Instantiate(olaf, new Vector3(Random.Range(-2.7f, 2.7f), 7, 0), Quaternion.identity);

            
                enemyCounter++;
             
                yield return new WaitForSeconds(5);
            }
            else yield return null; 


        }
    }
}