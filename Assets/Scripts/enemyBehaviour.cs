using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public float minMovementSpeed;
    public float maxMovementSpeed;
    public int health, maxHealth;
    public int enemyDamage;
    public GameObject Spawner;
    public int enemyValue;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        movementSpeed = Random.Range(minMovementSpeed, maxMovementSpeed);
        Spawner = GameObject.Find("Spawner").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        if (health <= 0)
        {
            Spawner.GetComponent<spawnScript>().enemyCounter--;
            UIScript.instance.addPoint();
            Destroy(gameObject);
        }

        if (transform.position.y <= -8)
        {
            transform.position = new Vector3(Random.Range(-6, 6), 4f, 0);
        }
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collides with the player.
        if (other.CompareTag("Player"))
        {
            playerScript playerScript = other.GetComponent<playerScript>();
            if (playerScript != null)
            {
                playerScript.takeDamage(enemyDamage);
            }

            Spawner.GetComponent<spawnScript>().enemyCounter--;
            Destroy(gameObject);
        }
    }
    public void takeDamage(int damage)
    {
        health -= damage;
    }
}
