using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class enemyScript : MonoBehaviour
{

    public float enemyHealth = 100f;
 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -2.80f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
      void OnTriggerEnter2D(Collider2D other)
    {
            if (other.tag == "Player") ;
            {
                other.transform.GetComponent<playerMovement>().TakeDamage(5);
            }

            if (other.tag == "Laser")
            {
                Destroy(gameObject);
            }
        }

}
}
