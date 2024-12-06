using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alien : MonoBehaviour
{
    public float speed;
    public int enemyHealth;
    public void TakeDamage()
    {
        enemyHealth--;
        if (enemyHealth <= 0)
        {
            Destroy(this.gameObject);
            GameObject Spawner = GameObject.FindWithTag("SpawnMaster");
            Spawner.transform.GetComponent<spawnmaster>().DecreaseEnemyCounter();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        
        if(transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Hit: " + other.name);

        if (other.tag == "Player")
        {
            other.transform.GetComponent<playerScript>().TakeDamage();
            //TakeDamage();
        }
        if (other.tag == "Player2")
        {
            other.transform.GetComponent<playerScript2>().TakeDamage();
            //TakeDamage();
        }

        if (other.tag == "Laser")
        {
            TakeDamage();
            Destroy(other.gameObject);
        } 
    }
}
