using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public int playerMaxHealth;
    public GameObject laserBullet;
    private float nextShot = 0f;
    [SerializeField] private float fireDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3, 0);
        playerHealth = playerMaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime );
        
        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime );

        /*
         // Modifiera den här koden för att göra wrap around effekt för spelaren.
        if (transform.position.x <= 7)
        {
            transform.position = new Vector3(-6.9, 0, 0);
        }
        
        if (transform.position.x <= -7)
        {
            transform.position = new Vector3(6.9, 6f, 0);
        }
        */

        if (Input.GetKey(KeyCode.Space) && Time.time > nextShot)
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            nextShot = Time.time + fireDelay;
        }
    }
    public void takeDamage(int damage)
    {
        playerHealth -= damage;

        if (playerHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
