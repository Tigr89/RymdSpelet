using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firing : MonoBehaviour
{
    public float laserSpeed = 2;
    public int laserDMG = 5;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

        if (transform.position.y > 6)
        {
            Destroy(gameObject);
        }
        
    }
}
