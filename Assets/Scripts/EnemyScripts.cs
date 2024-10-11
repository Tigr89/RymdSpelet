using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScripts : MonoBehaviour
{

    public float movementSpeed;
    public int EnemyHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        if (transform.position.y < -8)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 9, 0);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("trigger " + collision.name);

        //If enemy ship collide with Player, - then boom!
        if (collision.name == "Player")
        {
            //if (collision.name == "EnemyShip")
            //Kommunicera med playerScript och kalla på TakeDamage()
            //Player.GetComponent<playerScript>();

            collision.GetComponent<playerScript>().TakeDamage();


            Destroy(gameObject);
        }

        //If enemy ship get struck by laser, - then take damage!
        if (collision.tag == "Bullet")
        {
            TakeDamage();
            Destroy(collision.gameObject);
        }
        

    }
    public void TakeDamage()
    {
        EnemyHealth--;

        Debug.Log("Enemy health: " + EnemyHealth);

        if (EnemyHealth < 1)
        {
            Destroy(gameObject);
        }
    }
}
