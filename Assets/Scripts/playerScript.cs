using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    //Player Movement
    public float movementSpeed;

    //Player Weapons
    public GameObject laserBullet;
    private float nextShot = 0f;
    [SerializeField] private float fireDelay = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        //Teleports player to start position
        transform.position = new Vector3(0, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        //Allows horizontal movement
        float inputX;
        inputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime );
        
        //Allows vertical movement
        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime );

        
         // Modifiera den här koden för att göra wrap around effekt för spelaren.
        if (transform.position.x >= 6.8)
        {
            transform.position = new Vector3((float)-6.79, transform.position.y, 0);
        }
        
        if (transform.position.x <= -6.8)
        {
            transform.position = new Vector3((float)6.79, transform.position.y, 0);
        }
        

        //Let's the player shoot by holding space
        if (Input.GetKey(KeyCode.Space) && Time.time > nextShot)
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            nextShot = Time.time + fireDelay;
        }
    }
}
