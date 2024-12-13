using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour

{
    public GameObject enemyShip;
    private int enemyCount;
    private GameObject player;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(enemySpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator enemySpawner()
    {

        while (true)
        {
            if (enemyCount < 5 && GameObject.Find("player") != null)
            {
              
                Instantiate (enemyShip , new Vector3 (Random.Range(-8, 8), 7, 0), Quaternion.identity);
                enemyCount++;
                yield return new WaitForSeconds(5); //How long the loop should wait before it runs aigan
            }
            else yield return null;
        }

    }

}
