using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public GameObject laserBullet;
    private float _nextShot = 0f;
    [SerializeField] private float _fireDelay = 0.5f;
    public GameObject playerSpawner;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3, 0);
        
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
        if (transform.position.x <= 9)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 6f, 0);
        }
        
        if (transform.position.x <= 9)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 6f, 0);
        }
        */

        if (Input.GetKey(KeyCode.Space) && Time.time > _nextShot)
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            _nextShot = Time.time + _fireDelay;
        }


    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Check if the object collides with the player.
        if (other.CompareTag("Enemy"))
        {
            playerSpawner.GetComponent<playerSpawnScript>().playerLives--;
            Destroy(gameObject);
        }
    }
}
