using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    private float playerSpeed = 3;
    private int playerhealth = 3;


    public float movementspeed;
    public GameObject laserGreen;
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

        transform.Translate(Vector3.right * movementspeed * inputX * Time.deltaTime);

        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(laserGreen, transform.position + new Vector3(0, 0.6f, 0), Quaternion.identity);
        }
    }
    public void TakeDamage(int damage)
    {
      
    }
}

