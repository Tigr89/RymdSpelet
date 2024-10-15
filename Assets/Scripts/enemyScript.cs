using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public int enemyHealth;
    public int enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void Start()
        {
            transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        }
    }
}
