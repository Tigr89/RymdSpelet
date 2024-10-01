using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public int enemyCounter;
    public int meteorCounter;
    public GameObject Enemy;
    public GameObject Player;
    public GameObject laserBullet;
    public GameObject Meteor;
    public GameObject speedLine;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner());
        StartCoroutine(MeteorSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //IEnumerator 
    IEnumerator EnemySpawner()
    {
        while (true)
        {
            //if (GameObject.FindWithTag("Player") != null)
            if (enemyCounter < 3 && GameObject.FindWithTag("Player") != null)
            {
                Instantiate(Enemy, new Vector3(Random.Range(-8, 8), 5.5f, 0), Quaternion.identity);
                enemyCounter++;
                Debug.Log(enemyCounter);
                yield return new WaitForSeconds(3);
            }
            else
            {
                yield return null;
            }
            
        }

   

    }
    IEnumerator MeteorSpawner()
    {
        while (true)
        {
            //if (GameObject.FindWithTag("Player") != null)
            if (enemyCounter == 2 && GameObject.FindWithTag("Player") != null)
            {
                Instantiate(Meteor, new Vector3(Random.Range(-8, 8), 5.5f, 0), Quaternion.identity);
                meteorCounter++;

                Debug.Log(meteorCounter);
                yield return new WaitForSeconds(2);
            }
            else
            {
                yield return null;
            }

        }

    }
}
