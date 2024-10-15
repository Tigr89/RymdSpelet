using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float movementSpeed; 
    public int playerHealth;
    public GameObject Laser;
    public int ammoCount = 10;
    public int maxAmmo = 10;
    private int resupplyDelay = 5;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -3, 0);
    }

    // Update is called once per frame
    void Update()
    {
        // Movement

        float inputX;
        inputX = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.right * movementSpeed * inputX * Time.deltaTime);

        float inputY;
        inputY = Input.GetAxis("Vertical");

        transform.Translate(Vector3.up * movementSpeed * inputY * Time.deltaTime);

        if (Input.GetButtonDown("Fire1") && ammoCount > 0)
        {
            Instantiate(Laser, transform.position + new Vector3(0, 0.6f, 0), Quaternion.identity);
            ammoCount--;
        }

        if (Input.GetKeyDown(KeyCode.R) || (Input.GetButtonDown("Fire1") && ammoCount == 0))
        {
            StartCoroutine(ResupplyAmmo());
        }

    }

    private IEnumerator ResupplyAmmo()
    {
        // Check if already at max ammo
        if (ammoCount >= maxAmmo)
        {
            Debug.Log("Ammo is already full!");
            yield break; // Exit the coroutine if ammo is full
        }

        Debug.Log("Resupplying ammo...");

        // Wait for the specified delay
        yield return new WaitForSeconds(resupplyDelay);

        // Resupply ammo
        ammoCount = maxAmmo;
        Debug.Log("Ammo resupplied to: " + ammoCount);
    }
}