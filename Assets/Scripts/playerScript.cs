using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    public int playerHealth;
    public int playerLives;
    public GameObject laserBullet;
    private float _nextShot = 15f;
    [SerializeField] private float _fireDelay = 0.5f;

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

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime );
        
        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime );

        if (Input.GetKey(KeyCode.Space) && Time.time > _nextShot)
        {
            Instantiate(laserBullet, transform.position, Quaternion.identity);
            _nextShot = Time.time + _fireDelay;
        }


    }
}
