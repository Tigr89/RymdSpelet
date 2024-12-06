using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public float playerSpeed = 1.0f;
    public GameObject projectile;
    public float cooldownTime = 0.5f;
    private float lastTimeUsed;
    public float projectileDamage = 25;
    public GameObject enemyObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space) && Time.time > lastTimeUsed + cooldownTime)
        {
            lastTimeUsed = Time.time;
            Instantiate(projectile, this.transform.position, this.transform.rotation);
        }
        if (transform.position.x < -6.5f)
        {
            transform.position = new Vector3(8.65f, transform.position.y, 0);    
        }
        if (transform.position.x > 8.65f)
        {
            transform.position = new Vector3(-6.5f, transform.position.y, 0);
        }
    }

}
