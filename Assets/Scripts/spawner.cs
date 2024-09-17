using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class spawner : MonoBehaviour
{

    public int enemyCounter;
    public GameObject Enemy;
    public GameObject Player;
    public GameObject laserBullet;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner());
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

}
