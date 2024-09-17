using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    public float speed;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
            //The laser moves up at the desired speed.
            transform.Translate(Vector3.up * speed * Time.deltaTime);

        //If the laser gets  out of bounds (which in my case was 8 in y-axis) it will destroy itself.
        if (transform.position.y > 8)
        {
            Destroy(gameObject);
        }
    }
}