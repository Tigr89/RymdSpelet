using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public GameObject laser;
    public float movementSpeed = 5;
    public bool canShoot;
    public int playerHP = 100;

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

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
    }
    public void TakeDamage()
    {
        playerHP -= 20;

        if (playerHP <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.tag == "")
        {
            TakeDamage();
        }
       
    }
}

