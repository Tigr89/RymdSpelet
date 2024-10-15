using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeteorScript : MonoBehaviour
{
    public GameObject Manager;
    public float movementSpeed;
    public int damage;
    public GameObject winScreen;


    // Start is called before the first frame update
    void Start()
    {
        Manager = GameObject.Find("Manager");
        winScreen = GameObject.Find("winScreen");
    }

    // Update is called once per frame
    void Update()
    {
        Manager = GameObject.Find("Manager");
        winScreen = GameObject.Find("winScreen");

        if (winScreen != null && winScreen.activeInHierarchy)
        {
            Destroy(gameObject);
            Debug.Log("meteorerna dör");
        }

        //variera rörelsen
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        //transform.Translate(new Vector3(Random.Range(-10, 10) * Time.deltaTime, -1, 0) * movementSpeed * Time.deltaTime);

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
            other.GetComponent<playerScript>().TakeDamage(damage);

        }
        if (other.tag == "Shield")
        {
            other.gameObject.SetActive(false);
        }


        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            Manager.GetComponent<spawner>().enemyCounter--;
        }

    }
}
