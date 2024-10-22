using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed;
    private float inputX;
    public GameObject laserPrefab;
    public GameObject[] playerDupe;
    public Vector3 laserOffset;

    // Start is called before the first frame update
    void Start()
    {
        playerDupe[0].transform.position = new Vector3(0, -3, 0);
        //
    }

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Time.deltaTime * movementSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Time.deltaTime * movementSpeed);
        }*/

        
        inputX = Input.GetAxis("vågrätt");

        transform.Translate(new Vector3(1, 0, 0) * movementSpeed * inputX * Time.deltaTime);

        //När spelaren klickar på space, då ska en laser spawnas.
        if(Input.GetKey(KeyCode.Space))
        {
            PlayerFire();
        }

        if (playerDupe[0].transform.position.x < 0)
        {
            playerDupe[1].transform.position = playerDupe[0].transform.position + new Vector3(18, 0, 0);  
        }

        if (playerDupe[0].transform.position.x >= 0)
        {
            playerDupe[1].transform.position = playerDupe[0].transform.position + new Vector3(-18, 0, 0);
        }

        if (playerDupe[0].transform.position.x > 18 || playerDupe[0].transform.position.x < -18)
        {
            playerDupe[0].transform.position = playerDupe[1].transform.position;
        }
    }

    private void PlayerFire()
    {
        //if(//STuff)
        {
            Instantiate(laserPrefab, playerDupe[0].transform.position + new Vector3(0.44f, 0.36f, 0), Quaternion.identity);
        }
        else
        {
            Instantiate(laserPrefab, playerDupe[1].transform.position + new Vector3(-0.44f, 0.36f, 0), Quaternion.identity);
        }
    }
}
