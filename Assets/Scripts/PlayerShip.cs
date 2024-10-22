using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShip : MonoBehaviour
{
    //Vad ska spelaren kunna g�ra?
    public string playerName;

    //Skjuta
    public GameObject laserBeam;


    //Ta skada (h�lsa)
    public int playerHealth;

    //R�ra p� sig
    public float playerSpeed = 7f;


    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -5, 0);

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
        }
    }
}
