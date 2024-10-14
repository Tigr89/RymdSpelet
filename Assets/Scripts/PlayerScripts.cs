using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerScripts : MonoBehaviour
{
    public float movementSpeed;
    public float rotateSpeed;

    public GameObject playerShot;
    public bool canShoot;
    int canShootCooldown;
    public int canShootCooldownBase;

    public float powerupMovementSpeedChange; // The strength of the power up.
    public int powerupMovementSpeedTimerBase; // The base time.
    int powerupMovementSpeedTimer = 0; // The current time.
    public int powerupShootCooldownChange; // The strength of the power up.
    public int powerupShootCooldownTimerBase; // The base time.
    int powerupShootCooldownTimer = 0; // The current time.

    public int playerHealth;
    public int playerLife;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0f, -3f, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (powerupMovementSpeedTimer <= 0)
        {
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * movementSpeed);
            }

            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                transform.Translate(Vector3.left * Time.deltaTime * movementSpeed);
            }

            if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                transform.Translate(Vector3.down * Time.deltaTime * movementSpeed);
            }

            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                transform.Translate(Vector3.right * Time.deltaTime * movementSpeed);
            }
        }
        else
        {
            if (Input.GetKey(KeyCode.UpArrow) == true)
            {
                transform.Translate(Vector3.up * Time.deltaTime * (movementSpeed + powerupMovementSpeedChange));
            }

            if (Input.GetKey(KeyCode.LeftArrow) == true)
            {
                transform.Translate(Vector3.left * Time.deltaTime * (movementSpeed + powerupMovementSpeedChange));
            }

            if (Input.GetKey(KeyCode.DownArrow) == true)
            {
                transform.Translate(Vector3.down * Time.deltaTime * (movementSpeed + powerupMovementSpeedChange));
            }

            if (Input.GetKey(KeyCode.RightArrow) == true)
            {
                transform.Translate(Vector3.right * Time.deltaTime * (movementSpeed + powerupMovementSpeedChange));
            }
        }


        if (this.transform.position.x >= 9)
        {
            this.transform.position = new Vector3(-8.99f, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.x <= -9)
        {
            this.transform.position = new Vector3(8.99f, this.transform.position.y, this.transform.position.z);
        }
        if (this.transform.position.y >= 5)
        {
            this.transform.position = new Vector3(this.transform.position.x, -4.99f, this.transform.position.z);
        }
        if (this.transform.position.y <= -5)
        {
            this.transform.position = new Vector3(this.transform.position.x, 4.99f, this.transform.position.z);
        }

        if (canShoot == true && Input.GetKey(KeyCode.Space) == true)
        {
            Instantiate(playerShot, this.transform.position, transform.rotation);
            canShoot = false;
            if (powerupShootCooldownTimer <= 0)
            {
                canShootCooldown = canShootCooldownBase;
            }
            else
            {
                canShootCooldown = canShootCooldownBase - powerupShootCooldownChange;
            }
        }
        if (canShootCooldown > 0)
        {
            canShootCooldown = canShootCooldown - 1;
        }
        if (canShootCooldown <= 0)
        {
            canShoot = true;
        }
        if (powerupShootCooldownTimer > 0)
        {
            powerupShootCooldownTimer = powerupShootCooldownTimer - 1;
        }
        if (powerupMovementSpeedTimer > 0)
        {
            powerupMovementSpeedTimer = powerupMovementSpeedTimer - 1;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            int poewrupType = collision.gameObject.GetComponent<PowerUpScript>().GetPowerupType;

            if (poewrupType == 1)
            {
                powerupMovementSpeedTimer = powerupMovementSpeedTimerBase;
            }
            else
            {
                powerupShootCooldownTimer = powerupShootCooldownTimerBase;
            }

            Destroy(collision.gameObject);
        }
    }
}
