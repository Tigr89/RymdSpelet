using System.Collections;
using System.Collections.Generic;
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
        //Enemy is moving down at the desired speed
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        //If the enemy gets out of bounds they will respawn at a random position on the x-axis and at 5.5 on the
        //y-axis. Vector3 accepts three arguments: x, y and z. On x a Random.Range() is used. 
        //Random.Range gives a value between -8 and 8 when called.
        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
    }

    //A method available by the unity API. If two items collide this code will run.
    //Collider2D is a datatype also made available by the unity API. The name of this variable
    //may be different for you when you call on the script (i.e. might be "Collider2D collider), and the
    //smaller case "collider" is simply the variable name. It could be anything. In my example below
    //it is "other" but if you named it "Bob" it would still work.
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