using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shell : MonoBehaviour
{
    public float shellSpeed;
    public int shellweight;
    public Rigidbody2D rb;
    public GameObject shellobject;
    
    void Start()
    {
        Destroy(gameObject, 3.9f);

        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        this.transform.Translate(Vector3.left * shellSpeed * Time.deltaTime);

        shellobject.transform.Rotate(new Vector3(0, 0, 18) * Time.deltaTime * 20);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            Debug.Log("Hit ground");
            transform.Rotate(new Vector3(0, 0, 0) * Time.deltaTime * 0);
            
            rb.AddRelativeForce(transform.up * 1000);

            rb.AddRelativeForce(transform.right * -600);


        }
    }
}
