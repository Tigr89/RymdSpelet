using System.Runtime.CompilerServices;
using UnityEngine;

public class enemy : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
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

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Player")
        {

            other.transform.GetComponent<Playerscript>().TakeDamage();
           
            Debug.Log("Hit: " + other);
        }

        if(other.tag == "Laser")
        {
            Destroy(gameObject);
        }




    }




}    

