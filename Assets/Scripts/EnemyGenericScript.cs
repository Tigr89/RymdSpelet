using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenericScript : MonoBehaviour
{
    public float movementSpeed;
    public int health;
    public int damage;
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        this.transform.position = new Vector3(this.transform.position.x, this.transform.position.y - movementSpeed, this.transform.position.z);
        if (this.transform.position.y < -5)
        {
            float randomSpawn = Random.Range(-8.5f, 8.5f);
            this.transform.position = new Vector3(randomSpawn, 5f, this.transform.position.z);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerAttack")
        {
            health = health - 1;
            if (health <= 0)
            {
                Destroy(this.gameObject);
            }
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
        }
    }
}
