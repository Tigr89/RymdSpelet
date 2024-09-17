using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemie_Script : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);


        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);

        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
            other.transform.GetComponent<playerScript>().TakeDamage();

        // Nedanstående kod ska nog vara en "if sats"?
        if (other.tag == "Bullet")
        {
            //Destroy är inte det du skrivit nedan utan det ska vara Destroy(gameObject)
            Destroy(gameObject);

        }
    }
}