using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyBehaviour : MonoBehaviour
{
    public float enemySpeed;
    public float outOfBounds;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Random.Range(-7.9f, 7.9f), 5.6f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        if(this.transform.position.y < -outOfBounds)
        {
            transform.position = new Vector3(Random.Range(-outOfBounds, outOfBounds), 5.6f, 0);
        }
    }

    public void TakeDamage()
    {

    }

}
