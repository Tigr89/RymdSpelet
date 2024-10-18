using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHP;
    public GameObject laserBullet;
    public GameObject Canvas;
    public GameObject Shield;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
        Shield.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxisRaw("Horizontal");

        float inputY;
        inputY = Input.GetAxisRaw("Vertical");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);
        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime);

        if (transform.position.y < -4.6)
        {
            transform.position = new Vector3(transform.position.x, -4.6f, transform.position.z);
        }

        if (transform.position.y > 4.6)
        {
            transform.position = new Vector3(transform.position.x, 4.6f, transform.position.z);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            
        }

        //wrap-around:
        if (transform.position.x >= 10)
        {
            
            transform.position = new Vector3(-9, transform.position.y, transform.position.z);
        }

         if (transform.position.x <= -10)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }
    }

    public void TakeDamage(int playerDamage)
    {
        playerHP = playerHP - playerDamage;

        if (playerHP <= 0)
        {
            playerHP = 0;
            Destroy(gameObject);
            Canvas.GetComponent<UI>().playerHP = playerHP;
        }

        Canvas.GetComponent<UI>().playerHP = playerHP;


    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //plockar upp och aktiverar sköld
        if (other.tag == "Pickup")
        {
            Shield.SetActive(true);
            Destroy(other.gameObject);
        }
    }
}
