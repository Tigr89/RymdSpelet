using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBehaviour : MonoBehaviour
{
    public float laserSpeed;
    public int laserDamage;
    public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object hit is an enemy
        if (other.CompareTag("Enemy"))
        {
            enemyBehaviour enemyBehaviour = other.GetComponent<enemyBehaviour>();
            if (enemyBehaviour != null)
            {
                enemyBehaviour.takeDamage(laserDamage);
            }

            Instantiate(hitEffect, transform.position, Quaternion.identity);

            // Destroy the projectile
            Destroy(gameObject);
        }
    }
}
