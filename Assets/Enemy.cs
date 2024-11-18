using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float movementSpeed = 1;
    public float power_up;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 9, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);

        if (gameObject == null)
        {
            Instantiate(power_up, this.transform.position, this.transform.rotation);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
