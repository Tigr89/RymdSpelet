using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public GameObject laserBullet;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            
        }

        if (transform.position.x >= 10)
        {
            
            transform.position = new Vector3(-9, transform.position.y, transform.position.z);
        }

         if (transform.position.x <= -10)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }
        

    }
}
