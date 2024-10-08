using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject enemyShip;
    public int enemyCounter = 0;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        //This code activates the IEnumerator listed below. 
        StartCoroutine(EnemySpawner());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator EnemySpawner()
    {

        //this while loop will run forever.
        while (true)
        {
            
            if (enemyCounter < 3 && GameObject.Find("Player") != null)
            {
                
                Instantiate(enemyShip, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

            
                enemyCounter++;

                //The code will wait for five second at this line. Once five seconds have passed it will repeat
                //the while loop. 
                yield return new WaitForSeconds(5);
            }
            else yield return null; //if the above if statement is false the yield will return nothing. 


        }
    }
}