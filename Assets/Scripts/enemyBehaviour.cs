using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public float minMovementSpeed;
    public float maxMovementSpeed;
    public int health, maxHealth;
    public GameObject enemySpawner;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        movementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);
        enemySpawner = GameObject.Find("enemySpawner").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        if(transform.position.y <= -8)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 6f, 0);
        }
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collides with the player.
        if (other.CompareTag("Player"))
        {
            enemySpawner.GetComponent<spawnScript>().enemyCounter--;
            Destroy(gameObject);
        }
    }
    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            enemySpawner.GetComponent<spawnScript>().enemyCounter--;
            Destroy(gameObject);
        }

        

    }
}
