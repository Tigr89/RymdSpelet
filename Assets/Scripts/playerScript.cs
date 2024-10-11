using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHP;
    public GameObject laserBullet;
    public GameObject Canvas;
    

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            
        }

        if (transform.position.x >= 10)
        {
            
            transform.position = new Vector3(-9, transform.position.y, transform.position.z);
        }

         if (transform.position.x <= -10)
        {
            transform.position = new Vector3(9, transform.position.y, transform.position.z);
        }

        //Debug.Log("HP är " + playerHP);
    }

    public void TakeDamage(int playerDamage)
    {
        
        if (playerHP <= 0)
        {
            Destroy(gameObject);
        }

        //fortsätter under minus, dör inte
        Canvas.GetComponent<UI>().playerHP -= playerHP - playerDamage;





    }
}
