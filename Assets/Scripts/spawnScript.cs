using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour
{
    public GameObject enemy2;
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

    IEnumerator EnemySpawner()
    {
        while (true)
        {

            Instantiate(enemyShip, new Vector3(2, 5, 0), transform.rotation);
            yield return new WaitForSeconds(2);
        }


        yield return null;
    }
}
      