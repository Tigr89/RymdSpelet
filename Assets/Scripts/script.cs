using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int movementSpeed = 3;
        float inputX;
        inputX = Input.GetAxis("Horizontal");
        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime);


        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);


    }




}
