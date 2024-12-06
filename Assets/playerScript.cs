using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour

{

    public int playerHealth;
    public float playerspeed = 1.0f;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * playerspeed * Time.deltaTime);

        }   
        if (Input.GetKey(KeyCode.D)) 
        {
            transform.Translate(Vector3.right * playerspeed * Time.deltaTime); 
        }
        if (this.gameObject.transform.position.y > -4.62f && Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * playerspeed * Time.deltaTime);
        }
        if (this.gameObject.transform.position.y < 4.57f && Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * playerspeed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Instantiate(projectile, this.transform.position,this.transform.rotation);

        }
        if (this.gameObject.transform.position.x < -9f)
        {
            this.gameObject.transform.position = new Vector3(8.9f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
        if (this.gameObject.transform.position.x > 9f)
        {
            this.gameObject.transform.position = new Vector3(-8.9f, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
        }
    }
    public void TakeDamage()
    {
        playerHealth--;
        Debug.Log("Player health: " + playerHealth);
        
        if (playerHealth < 0)
        {
            Destroy(gameObject);
        }
    }
}
