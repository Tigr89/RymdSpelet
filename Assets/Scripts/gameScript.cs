using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameScript : MonoBehaviour
{
    private int enemyCount;
    public GameObject enemyShip;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        while (enemyCount < 5)
        {
            Instantiate(enemyShip, new Vector3(Random.Range(-7, 7), 6, 0), Quaternion.identity);
            enemyCount++;

        }
    }
}
