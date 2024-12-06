using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class astroid : MonoBehaviour
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
        // this.gameObject.transform.Rotate(0f, 0f, 2f);

        if (transform.position.y <= -5.5f)
        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log("Hit: " + other.name);

        if (other.tag == "Player")
        {
            other.transform.GetComponent<playerScript>().TakeDamage();
            //TakeDamage();
        }
        if (other.tag == "Player2")
        {
            other.transform.GetComponent<playerScript2>().TakeDamage();
            //TakeDamage();
        }

    }
}
