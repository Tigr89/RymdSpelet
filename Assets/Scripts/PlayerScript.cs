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
        transform.position = new Vector3(0, -1.71f, 0);
        transform.localScale = new Vector3(0, 0, 0);


    }


    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxis("Horizontal");
        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime);


        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, this.transform.position + new Vector3(0, 0.6f, 0), Quaternion.identity);


        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(0, -1.77f, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (transform.position.x < -9)
        {
            transform.position = new Vector3(0, -1.77f, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (transform.position.y > 5.1f)
        {
            transform.position = new Vector3(0, -1.77f, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (transform.position.y < -5.1f)
        {
            transform.position = new Vector3(0, -1.77f, 0);
            transform.localScale = new Vector3(0.16f, 0.16f, 0.16f);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }

        
            if(transform.localScale.x <= 0.6f)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
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