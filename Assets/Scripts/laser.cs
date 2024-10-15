using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float laserSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);//
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

    }
   
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "enemy")
        {

            Destroy(other.gameObject);
        }

        if (other.name != "Player")
        {
            Destroy(gameObject);

        }

       

    }





}

