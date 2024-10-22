using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class laser : MonoBehaviour
{
    public float laserSpeed = 10f;
    public bool enemyLaser;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, 5);//
    }

    // Update is called once per frame
    void Update()
    {
       

        if (enemyLaser == false)
        {
            transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

        }
        else
        {

            transform.Translate(Vector3.down * laserSpeed * Time.deltaTime);

        }
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

