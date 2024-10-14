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
            canShootCooldown = canShootCooldownBase;
        }
        if (canShootCooldown > 0)
        {
            canShootCooldown = canShootCooldown - 1;
            if (canShootCooldown <= 0)
            {
                canShoot = true;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PowerUp")
        {
            movementSpeed = movementSpeed * 1.1f;
            if (canShootCooldownBase > 1)
            {
                canShootCooldownBase = canShootCooldownBase - 3;
            }

            Destroy(collision.gameObject);
        }
    }
}
