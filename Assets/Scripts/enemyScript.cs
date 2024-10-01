using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        //Checks whether the other has the tag "Player". If true, it executes the code below.
        //In order for this to work you need to assign tags to objects in the unity editor. This
        //is done in the inspector window
        if (other.tag == "Player")
        {
            //Call on method in player to deal damage
            other.transform.GetComponent<playerScript>().TakeDamage();
            Debug.Log("Hit: " + other);
        }

        if (other.tag == "Laser")
        {
            Destroy(gameObject);
        }
    }
}
