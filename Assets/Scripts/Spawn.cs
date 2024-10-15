using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject olaf;
    private int enemyCounter;
    private GameObject Player;

    Quaternion enemy_rotation = Quaternion.Euler(0, 0, -90);

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

                Instantiate(olaf, new Vector3(10, Random.Range(4.55f, -2.6f), 7), enemy_rotation); 



                enemyCounter++;
             
                yield return new WaitForSeconds(5);
            }
            else yield return null; 


        }
    }
}