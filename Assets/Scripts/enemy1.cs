using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine.UIElements;

public class enemy1 : MonoBehaviour
{
    public float speed;
    public GameObject laserBlue;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(laserx2());
        transform.position = new Vector3(Random.Range(-7, 7), 5.5f, 0);

    }
     // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if(transform.position.y <= -5.5f)
        {


            transform.position = new Vector3(Random.Range(-7, 7), 5.5f, 0);
        }
        

    }
    IEnumerator laserx2()
    {

        while (true)
        {
            Instantiate(laserBlue, transform.position, Quaternion.identity);

            yield return new WaitForSeconds(2);

        }
    }









}

