using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript2 : MonoBehaviour
{
    public int player2Health;
    public float player2speed = 1.0f;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * player2speed * Time.deltaTime);

        }   
        if (Input.GetKey(KeyCode.RightArrow)) 
        {
            transform.Translate(Vector3.right * player2speed * Time.deltaTime); 
        }
        if (this.gameObject.transform.position.y > -4.62f && Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * player2speed * Time.deltaTime);
        }
        if (this.gameObject.transform.position.y < 4.57f && Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * player2speed * Time.deltaTime);
        }
        if (Input.GetKeyDown(KeyCode.Keypad0))
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
        player2Health--;
        Debug.Log("Player2 health: " + player2Health);
        
        if (player2Health < 0)
        {
            Destroy(gameObject);
        }
    }
}
