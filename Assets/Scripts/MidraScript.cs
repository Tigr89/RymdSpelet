using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YuhScript : MonoBehaviour
{
    public float movementSpeed = 5;
    public bool canShoot;
    public int yuhHealth;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3, 0);


        
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
           
    }
}
