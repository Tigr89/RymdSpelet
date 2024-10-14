using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public int health, maxHealth;
    public int enemyDamage;
    public GameObject Spawner;
    public int enemyValue;
    public GameObject Canvas;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        Spawner = GameObject.Find("enemySpawner").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        if (health <= 0)
        {
            Spawner.GetComponent<enemySpawnScript>().enemyCounter--;
            UIScript.instance.addPoint(enemyValue);
            Destroy(gameObject);
        }

        if (transform.position.y <= -4)
        {
            transform.position = new Vector3(Random.Range(-6, 6), 4f, 0);
        }
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collides with the player.
        if (other.CompareTag("Player"))
        {
            UIScript UIScript = other.GetComponent<UIScript>();
            if (UIScript != null)
            {
                UIScript.takeDamage(enemyDamage);
            }

            Spawner.GetComponent<enemySpawnScript>().enemyCounter--;
            Destroy(gameObject);
        }
    }
    public void takeDamage(int damage)
    {
        health -= damage;
    }
}
