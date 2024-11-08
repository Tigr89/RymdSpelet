using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawner : MonoBehaviour
{
    public GameObject enemyShip;
    private int enemyCounter;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner()); 
    }

    // Update is called once per frame
    void Update()
    {

    }

    //IEnumerator is a type of Coroutine that is able to execute commands outside of update. This
    //particular IEnumerator repeats the code within the while-loop forever -- and under normal circumstances
    //this could be dangerous and crash the application. However, in the below example it only executes
    //the code once per 5 seconds. A coroutine must always have a "yield".
    IEnumerator EnemySpawner()
    {

        //this while loop will run forever.
        while (true)
        {
            //If enemyCounter is less than three and the player object is not null (i.e. it exists) then
            //it will run the code within the if statement.
            if (enemyCounter < 3 && GameObject.Find("Player") != null)
            {
                //The following code does the following:
                //Spawn the gameobject storedwithin the variable "enemyShip"
                //spawn it at the location: x = random number between -8 and 8; y = 7 and z = 0.
                Instantiate(enemyShip, new Vector3(Random.Range(-8, 8), 7, 0), Quaternion.identity);

                //the int variable "enemyCounter" gains +1 each time this code is run.
                enemyCounter++;

                //The code will wait for five second at this line. Once five seconds have passed it will repeat
                //the while loop. 
                yield return new WaitForSeconds(5);
            }
            else yield return null; //if the above if statement is false the yield will return nothing. 


        }
    }
}