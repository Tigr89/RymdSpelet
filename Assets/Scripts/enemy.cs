using UnityEngine;
using UnityEngine.UIElements;

public class enemy : MonoBehaviour

{

    public float movementSpeed = 1;
    public bool PositionY;
    public float EnemyHealth = 1;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector2(0, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * movementSpeed * Time.deltaTime);
        if (PositionY == true);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (EnemyHealth == 0)transform.position = Random.range;
    }


}
