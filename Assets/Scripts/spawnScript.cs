using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    //Enemy Variables
    public GameObject enemyShip;
    public int enemyCounter;
    public int enemyMaxCount;
    public float enemySpawnDelay;

    //Player Variables
    private GameObject player;
    /*public int playerHealth;
    public int playerMaxHealth;*/

    //Misc.
    public GameObject Canvas;

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
            if (enemyCounter < enemyMaxCount) 
            {
            Instantiate(enemyShip, new Vector3(Random.Range(-6, 6), 4f, 0), Quaternion.identity);
                enemyCounter++;

                yield return new WaitForSeconds(enemySpawnDelay);
                Debug.Log("Enemy counter is: " + enemyCounter);
            }
            else yield return null;
        }
    }
}
