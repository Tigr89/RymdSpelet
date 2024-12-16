using UnityEngine;
public class Enemy : MonoBehaviour

{
    public float movementSpeed = 1;
    public GameObject power_up;
    public GameObject power_up1;
    public GameObject power_up2;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 9);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);

        int dropChance = 20;
        int randomChance = Random.Range(0, 100);
        Debug.Log(randomChance);
        
        if (randomChance > dropChance + 60)
        {
            Instantiate(power_up, this.transform.position, this.transform.rotation);
        }
        else if (randomChance > dropChance + 40)
        {
            Instantiate(power_up1, this.transform.position, this.transform.rotation);
        }
        else if (randomChance > dropChance + 20)
        {
            Instantiate(power_up2, this.transform.position, this.transform.rotation);
        }

    }
}
