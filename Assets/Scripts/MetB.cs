using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetB : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        //Destroy(gameObject, 3);
        //if (transform.position.y <= -5.5) Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5) Destroy(gameObject);

    }
    
        
}
