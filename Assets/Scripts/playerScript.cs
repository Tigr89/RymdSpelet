using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public GameObject laserBullet;
    public int hitPoints;

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
        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, this.transform.position, Quaternion.identity);

        }
        if (transform.position.x > 9)
        {
            transform.position = new Vector3(-9, -3, 0);

        }
        if (transform.position.x < -9)
        {
            transform.position = new Vector3(9, -3, 0);
        }
    }
}
