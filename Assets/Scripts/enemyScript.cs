using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float movementSpeed;
    

    // Start is called before the first frame update
    void Start()
    {
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
    }

    //If two items collide this code will run.
    private void OnTriggerEnter2D(Collider2D other){
        
        if (other.tag == "Player")
        {
        Destroy(other.gameObject);
            //Call on method in player to deal damage
            //other.transform.GetComponent<playerScript>().TakeDamage();
            //Debug.Log("Hit: " + other);
        }

        else if (other.tag == "Laser")
        {
        Destroy(gameObject);
        Destroy(other.gameObject);
        }
    }
    

}






