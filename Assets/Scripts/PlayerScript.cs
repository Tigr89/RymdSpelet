using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public GameObject laserBullet;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3.33f, 0);
        transform.localScale = new Vector3(0, 0, 0);
        //test

    }


    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxis("Vertical");
        float inputY;
        inputY = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.up * movementSpeed * inputY * 0.95f * Time.deltaTime);


        transform.Translate(Vector3.right * movementSpeed * inputX * -1 * Time.deltaTime);

        Quaternion spaceship_rotation = transform.rotation;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, this.transform.position + new Vector3(0.3f, 0, 0), spaceship_rotation);
            
          


        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-7, -3, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (transform.position.x < -9)
        {
            transform.position = new Vector3(-7, -3, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (transform.position.y > 5)
        {
            transform.position = new Vector3(-7, -3, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (transform.position.y < -5)
        {
            transform.position = new Vector3(-7, -3, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }

        
            if(transform.localScale.x <= 0.6f)
        {
            transform.localScale += new Vector3(0.031f, 0.031f, 0.031f);
        }

    }
    public void TakeDamage()
    {
        playerHealth--;
        Debug.Log("Player Health: " + playerHealth);

        if (playerHealth < 0)
            Destroy(gameObject);
    }

}