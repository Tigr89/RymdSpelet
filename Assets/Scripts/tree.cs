using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    public float treespeed1;
    public float treespeed2;
    private float randomSpeedTree;
    // Start is called before the first frame update
    void Start()
    {
        randomSpeedTree = Random.Range(treespeed1, treespeed2);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * randomSpeedTree * Time.deltaTime);

        if (transform.position.x <= -9.5)
        {
            //transform.position = new Vector3(11, Random.Range(-5f, -6f), 7);
            Destroy(this.gameObject);
        }
    }
}
