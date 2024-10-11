using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    //Public variables are variables that can be manipulated by other scripts. Private variables cannot.
    //Public variables are always visible in the Inspector in the Unity Editor. If you want a private 
    //variable to be visible then you have to use [SerializeField]. 
    [SerializeField] private float playerSpeed = 3;
    public float horizontalMovement;

    public GameObject laserRed;
    public int playerHealth = 5;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the player's position to the X, Y, Z coordintes set within the parenthesis
        transform.position = new Vector3(-3, -3.5f, 0);

    }

    // Update is called once per frame
    void Update()
    {
        //Two different ways of doing movement listed below
        //NOTE: Pick ONE of these methods

        //First method: Move left/right with A and D.
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }


        //The second method. Result is the same but the code uses Unity's Input Manager
        float horizontalSpeed = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * horizontalSpeed * playerSpeed * Time.deltaTime);

        if (transform.position.x <= -9.5)
        {
            transform.position = new Vector3(9.5f, transform.position.y, 0);
        }

        //Command for spawning a laser. You need to have a reference to the laser in order to spawn it.
        //For this you can use the inspector in Unity and drag the desired prefab object into the "Laser Red"-slot
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserRed, this.transform.position, transform.rotation);
        }

        //Command for killing yourself
        if (Input.GetKeyDown(KeyCode.F))
        {
            Destroy(gameObject);
        }
    }

    //Method for taking damage. When you call TakeDamage() the player will deal damage to itself.
    //Other scripts can call on this method if there is a reference to the player character.
    public void TakeDamage()
    {
        playerHealth--;

        Debug.Log("Player health: " + playerHealth);

        if (playerHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
