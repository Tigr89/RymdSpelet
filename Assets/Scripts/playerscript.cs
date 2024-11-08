using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerscript : MonoBehaviour
{
    public float movementSpeed = 15;
    public bool canShoot;
    public int playerHealth = 3;
    public GameObject LaserRed;
    public GameObject enemyobject;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0, -3, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);


        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(LaserRed, this.transform.position, transform.rotation);
        }

        {
            playerHealth = 4;
            Debug.Log("Player health: " + playerHealth);

            if (playerHealth < 0)
            {
                Destroy(gameObject);
            }
        }

    }
    public void TakeDamage()
    {

    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            other.GetComponent<Enemy>().TakeDamage();
        }
    }
}


   

    
    


   

    

