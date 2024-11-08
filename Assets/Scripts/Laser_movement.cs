using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser_movement : MonoBehaviour
{
    public float bulletspeed = 3;
    public GameObject LaserRed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletspeed * Time.deltaTime);


        if (transform.position.y > 8)
        {
            Destroy(gameObject);
        }

        

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}




