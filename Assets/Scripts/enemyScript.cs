using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float movementSpeed;
    public int enemyHP;
    public int enemyValue;
    public int damage;
    public GameObject Manager;
    public GameObject Player;
    public GameObject winScreen;


    // Start is called before the first frame update
    void Start()
    {

        Manager = GameObject.Find("Manager").gameObject;
        Player = GameObject.Find("Player").gameObject;


        //transform.position = new Vector3(0, 8, 0);

    }


    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        if (transform.position.y <= -8.0f)
        {
        transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }

        if (winScreen != null && winScreen.activeInHierarchy)
        {
            Destroy(gameObject);
            Debug.Log("enemydör");
        }
    }

    //If two items collide this code will run.
    private void OnTriggerEnter2D(Collider2D other){
        
        if (other.tag == "Player")
        {
            other.GetComponent<playerScript>().TakeDamage(damage);
            Manager.GetComponent<spawner>().EnemyDeathTracker(0);
            Destroy(gameObject);

        }

        if (other.tag == "Laser")
        {
            enemyHP--;
            if (enemyHP <= 0)
            {
            Manager.GetComponent<spawner>().EnemyDeathTracker(enemyValue);
                Destroy(other.gameObject);
                Destroy(gameObject);
            
            }
        }

        if (other.tag == "Shield")
        {
            other.gameObject.SetActive(false);
            
        }
    }
    

}






