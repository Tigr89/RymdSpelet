using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))] 

public class screenWrap : MonoBehaviour
{
    private Rigidbody2D myRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Get the screen position of object in pixels.
        Vector3 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // Get the right side of the screen in world units.
        float rightSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).x;
        float leftSideOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).x;
        
        float topOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height)).y;
        float bottomOfScreenInWorld = Camera.main.ScreenToWorldPoint(new Vector2(0f, 0f)).y;
        // Player moves through left side
        if (screenPos.x <= 0 && myRigidBody.velocity.x < 0)
        {
            transform.position = new Vector2(rightSideOfScreenInWorld, transform.position.y);
        }

    }

}
