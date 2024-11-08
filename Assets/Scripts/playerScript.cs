using System.Collections;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public float movementSpeed = 5;
    public bool canShoot = true;
    public int playerHealth;
    public GameObject projectile;
    public float FireRate;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, -5, 0);



    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space) && canShoot == true)
        {
            Instantiate(projectile, this.transform.position, this.transform.rotation);
            StartCoroutine(BulletFireRate());
        }   
    }
    private IEnumerator BulletFireRate()
    {
        //Kod som ska ske innan CD
        canShoot = false;
        yield return new WaitForSeconds(FireRate);
        //Kod efter CD
        canShoot = true;
        yield return null;
    }
}