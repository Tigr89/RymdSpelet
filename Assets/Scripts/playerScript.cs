using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementspeed;
    public int playerhealth;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float inputX;
        inputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * movementspeed * inputX * Time.deltaTime);
    }
}
public class laserscript : MonoBehaviour
{
    public float speed;
    //start is called before the first frame update
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