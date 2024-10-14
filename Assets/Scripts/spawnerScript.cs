using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerScript : MonoBehaviour
{
    public GameObject enemyObject;
    public int enemyCounter;
    public GameObject playerObject;
    public GameObject Canvas;
    public int playerHealth;


    // Start is called before the first frame update
    void Start()
    {
        Canvas = GameObject.Find("Canvas");
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
            if (enemyCounter < 3 && playerObject != null)
            {
                Instantiate(enemyObject, new Vector3(Random.Range(-8, 8), 5.5f, 0), Quaternion.identity);
                enemyCounter++;

                yield return new WaitForSeconds(1);
                Debug.Log("Enemy counter is: " + enemyCounter);
            }
            else
            {
                yield return null;
            }
        }
        
    }

    public void EnemyDeath(int valueGiven, int enemyDeathCounter, string deathMessage)
    {
        enemyCounter--;
        Canvas.GetComponent<UIscript>().scoreValue += valueGiven;

    }

    public void PlayerTakeDamage()
    {
        playerHealth--;
        Canvas.GetComponent<UIscript>().UpdateHealth(playerHealth);
    }

}
