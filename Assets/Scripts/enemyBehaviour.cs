using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{

    public float movementSpeed;
    public int health, maxHealth;

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;

        transform.position = new Vector3(0, 6, 0);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

    }

    public void takeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
