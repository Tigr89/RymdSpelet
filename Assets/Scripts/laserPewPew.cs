using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserPewPew : MonoBehaviour
{
    public float laserSpeed;
    public int laserDamage;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

        
    }
    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            Debug.Log("Collided with " + other.tag);
        }
            else
        {
            
        }
        
    }
}
