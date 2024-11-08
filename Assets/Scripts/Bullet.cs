using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Bullet : MonoBehaviour
{

    public float bulletSpeed = 5;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 5);        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * bulletSpeed * Time.deltaTime);
    }

   
}
