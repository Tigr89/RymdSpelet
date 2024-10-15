using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.VFX;

public class enemyScript : MonoBehaviour
{
    public float speed;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);

        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            //Call on method in player to deal damage
            other.transform.GetComponent<playerScript>().TakeDamage();
            //Debug.Log("Hit: " + other);
        }

        if (other.tag == "Laser")
        {

            GameObject.Find("enemySpawner").transform.GetComponent<spawnScript>().enemyCounter -= 1;
            GameObject Score = GameObject.Find("Score Text");
            Debug.Log(GameObject.Find("enemySpawner"));
            Score.GetComponent<currentScore>().Score += 100;
            Destroy(gameObject);
        }
    }
}
