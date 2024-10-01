using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject enemyShip;
    public int enemyCounter;
    public int enemyMaxCount;
    public float spawnDelay;
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
            if (enemyCounter < enemyMaxCount && GameObject.Find("player") != null) 
            {
            Instantiate(enemyShip, new Vector3(Random.Range(-8, 8), 6f, 0), Quaternion.identity);
                enemyCounter++;

                yield return new WaitForSeconds(spawnDelay);
                Debug.Log("Enemy counter is: " + enemyCounter);
            }
            else yield return null;
        }
    }
}
