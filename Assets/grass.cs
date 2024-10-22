using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gräs : MonoBehaviour
{
    public float grässpeed1;
    public float grässpeed2;
    // Start is called before the first frame update
    void Start()
    {
       

       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * 15 * Time.deltaTime);
        
        if (transform.position.x <= -26.1f)
        {
            
            transform.position = new Vector3(8.38f, -2.71f, 0);
            
        }
    }
}
