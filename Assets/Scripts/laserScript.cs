using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    public float laserSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }
    // blablbla

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

        if(transform.position.y > 8)
        {
            Destroy(gameObject);
        }
        //

    }

    /*public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Collided with " + other.tag);
        }
        else
        {
            Destroy(other.gameObject);
        }
    }*/
}
