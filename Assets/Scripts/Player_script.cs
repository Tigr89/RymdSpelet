using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float movementSpeed = 5;
    public bool canShoot;
    public int playerHP;
    
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
           
            

        if (Input.GetKey(KeyCode.D)) 
        { 

            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
    }
}

