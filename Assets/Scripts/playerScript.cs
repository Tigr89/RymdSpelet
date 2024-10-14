using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public bool canShoot;
    [Header("Attack Stuff")]
    [SerializeField] private GameObject laserBullet;
    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        this.transform.position = new Vector3(0f, -3.1f, 0);
        transform.localScale = new Vector3(0, 0, 0);


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

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserBullet, transform.position /*+ new Vector3(0, 0.6f, 0)*/, Quaternion.identity);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            transform.localScale = new Vector3(0, 0, 0);
        }

        if(transform.localScale.x <= 0.6f)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
            
        }
        

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            gameManager.GetComponent<spawnerScript>().PlayerTakeDamage();

        }
    }


}
