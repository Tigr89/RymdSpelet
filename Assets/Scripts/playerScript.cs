using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public int playerLives;
    public GameObject laserBullet;

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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
        }


    }
}
