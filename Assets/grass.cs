using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gr�s : MonoBehaviour
{
    public float gr�sspeed1;
    public float gr�sspeed2;
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
