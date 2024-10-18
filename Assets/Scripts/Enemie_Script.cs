using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public int enemyHealth;
    public float speed;
    public float speed2;
    private float randomSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Tilldela en slumpmässig hastighet mellan speed och speed2
        randomSpeed = Random.Range(speed, speed2);
    }

    // Update is called once per frame
    void Update()
    {
        // Randomshit

        transform.Translate(Vector3.down * randomSpeed * Time.deltaTime);

        // Återställ positionen om fienden går utanför skärmen
        if (transform.position.x <= -9.5)
        {
            transform.position = new Vector3(10, Random.Range(4.55f, -2.6f), 7);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<playerScript>().TakeDamage();
        }

        if (other.CompareTag("Bullet"))
        {
            Destroy(other.gameObject); // Förstör kulan
            
            TakeDamage();
            Debug.Log("Jag är Dålig");
            //Destroy(gameObject); // Förstör fienden
        }
    }

    public void TakeDamage()
    {
        enemyHealth--;
        Debug.Log(enemyHealth);

        // ska dö
        if (enemyHealth <= 0)
        {
            GameObject.Find("SpawnObject").GetComponent<Spawn>().enemyCounter -= 1;
            Destroy(gameObject);
        }
    }
}
