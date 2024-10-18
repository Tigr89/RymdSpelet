using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float movementSpeed = 1;
    Vector2 randomPosition;
    public float yRange = 5f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 5, 0);
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
    }

    // Update is called once per frame
    void Update()
    {
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        { 
            return;
        }
        
        


    }

}
