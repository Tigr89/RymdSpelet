using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet1 : MonoBehaviour
{
    public float bulletSpeed = 1.0f;
    public int bulletDmg = 1;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime );
        }
         

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
            Destroy(gameObject);
    }
    public void DoDamage(int dmgDealth)
    {
        Debug.Log("HEJ!");
        /*enemy.GetComponent<enemyScript>().enemyHealth = enemy.GetComponent<enemyScript>().enemyHealth - projectileDamage);
        if (enemyHealth < 0)
        {
            Destroy(gameObject);

        }*/
    }
}
