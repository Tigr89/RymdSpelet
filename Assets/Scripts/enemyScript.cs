using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public int enemyHealth = 100;
    public int enemyDamage = 50;
    public int enemySpeed = 5;
    public bool respawn = false;
    int dmgDealt;


    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);
        if (transform.position.y < -2.80f && respawn == true)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
        if (transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            other.transform.GetComponent<playerMovement>().TakeDamage(enemyDamage);
        }

        if (other.tag == "Lazer")
        {
            DoDamage(other.transform.GetComponent<bullet1>().bulletDmg);
            other.transform.GetComponent<bullet1>().DoDamage(enemyHealth);
           
        }
    }
    public void DoDamage(int dmgDealth)
    {
        enemyHealth -= dmgDealth;
        if (enemyHealth < 0)
            {
            Destroy(gameObject);
        }
    }
 
}

