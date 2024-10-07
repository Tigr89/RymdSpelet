using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeteorScript : MonoBehaviour
{
    public GameObject Manager;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager").gameObject;
    }

    // Update is called once per frame
    void Update()
    {

        //variera rörelsen
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        //transform.Translate(new Vector3(Random.Range(-10, 10), -1, 0) * movementSpeed * Time.deltaTime);

        if (transform.position.y <= -8.0f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
    }

    //If two items collide this code will run.
    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
            //Call on method in player to deal damage

        }
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Manager.GetComponent<spawner>().enemyCounter--;
        }

    }
}
