using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float speed;
    int TakeDamage = 0;

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
       public class playerScript : MonoBehaviour
    {
        // Example TakeDamage method
        public void TakeDamage(int damage)
        {
            // Your damage logic here
        }
    }
}