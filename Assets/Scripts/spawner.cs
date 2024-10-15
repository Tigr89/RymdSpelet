using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;


public class spawner : MonoBehaviour
{

    public int enemyCounter;
    public int meteorCounter;
    public GameObject Manager;
    public GameObject Enemy;
    public GameObject Player;
    public GameObject Meteor;
    public GameObject speedLine;
    public GameObject Canvas;
    public GameObject winScreen;
    public int playerScore;

    public GameObject Pickup;
    public int pickupCounter;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(EnemySpawner());
        StartCoroutine(MeteorSpawner());
        StartCoroutine(PickupSpawner());
        GameObject.Find("winScreen");

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

            if (enemyCounter < 3 && GameObject.FindWithTag("Player") != null)
                
            {
                Instantiate(Enemy, new Vector3(Random.Range(-8, 8), 5.5f, 0), Quaternion.identity);
                enemyCounter++;
                //Debug.Log(enemyCounter);
                yield return new WaitForSeconds(3);
            }

            if (winScreen != null && winScreen.activeInHierarchy)
            {
                //Debug.Log("Stopping spawns because win screen is active.");
                yield break;
            }
            yield return null;
        }

    }
    
    
    IEnumerator MeteorSpawner()
    {
        while (true)
        {
            
            if (meteorCounter < 5 && GameObject.FindWithTag("Player") != null)
            {
                Instantiate(Meteor, new Vector3(Random.Range(-8, 8), 5.5f, 0), Quaternion.identity);
                meteorCounter++;
                //Debug.Log(meteorCounter);
                yield return new WaitForSeconds(5);
            }

            if (winScreen != null && winScreen.activeInHierarchy)
            {
                Debug.Log("meteor spawn stops because win screen is active");
                yield break;
            }
            yield return null;
        }

    }

   
    IEnumerator PickupSpawner()
    {
        while (true)
        {
            if (pickupCounter < 1 && meteorCounter > 2)
            {
                Instantiate(Pickup, new Vector3(Random.Range(-8, 8), Random.Range(-4, 4), 0), Quaternion.identity);
                pickupCounter++;
                Debug.Log(pickupCounter);
                Destroy(gameObject);
                yield return new WaitForSeconds(2);
            }
            yield return null;
        }
    }

        public void EnemyDeathTracker(int enemyValue)
    {
        enemyCounter--;
        Canvas.GetComponent<UI>().playerScore += Enemy.GetComponent<enemyScript>().enemyValue;
    }
}
