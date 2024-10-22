using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tree : MonoBehaviour
{
    public float treespeed1;
    public float treespeed2;
    private float randomSpeedTree;
    private int dice;
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sten1;
    public Sprite sten2;
    public Sprite sten3;
    public Sprite träd3;
    // Start is called before the first frame update
    void Start()
    {
        randomSpeedTree = Random.Range(treespeed1, treespeed2);

        dice = Random.Range(0, 5);

        if (dice == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        if (dice == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sprite2;
        }
        if (dice == 2)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sten1;
        }
        if (dice == 3)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sten2;
        }
        if (dice == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = sten3;
        }
        if (dice == 4)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = träd3;
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * randomSpeedTree * Time.deltaTime);

        if (transform.position.x <= -9.5)
        {
            //transform.position = new Vector3(11, Random.Range(-4.08f, -4.2f), 7);
            Destroy(this.gameObject);
        }
    }
}
