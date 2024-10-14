using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public float respawnTimer;
    public int enemyCounter;
    public GameObject[] enemyObject;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner());
    }


    // Update is called once per frame
    IEnumerator EnemySpawner()
    {
        while(true)
        {
            if(enemyCounter < 5)
            {
                Instantiate(enemyObject[Random.Range(0,2)], new Vector3(Random.Range(-7.9f, 7.9f), 5.6f, 0), transform.rotation);
                enemyCounter = enemyCounter + 1;
                yield return new WaitForSeconds(respawnTimer);
            }
            yield return null;



        }

        yield return null;
    }
}
