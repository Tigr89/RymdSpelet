using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float movementSpeed = 100;
    public bool canShoot;
    public int playerHealth;
    public GameObject laserRed;
    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0f, -3.1f, 0);


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


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserRed, this.transform.position, transform.rotation);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
        
       
        

    }








    public void TakeDamage()
    {

        playerHealth--;
        Debug.Log("Player health: 100 " + playerHealth);

        if (playerHealth < 0)
        {

            Destroy(gameObject);

        }
        

        



    }

}
