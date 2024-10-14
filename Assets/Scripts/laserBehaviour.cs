using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserBehaviour : MonoBehaviour
{
    public float laserSpeed;
    public float actualTime;

    public Sprite laserBoom;
    private SpriteRenderer sRenderer;

    private bool isExpanding = true;

    public BoxCollider2D box2D;

    // Start is called before the first frame update
    void Start()
    {
        sRenderer = GetComponent<SpriteRenderer>();

        StartCoroutine(LaserExplosion(0.5f, 0.7f));

        box2D = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector3.up * laserSpeed * Time.deltaTime);

        if(this.transform.position.y > 7)
        {
            Destroy(this.gameObject);
        }

        
    }


    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy")
        {
            //Stuff happens
            //Villkor som gör att IEnumeratorn exploderar omedelbart

            Destroy(other.gameObject);

        }
    }

    IEnumerator LaserExplosion(float timer1, float timer2)
    {
        
        

        yield return new WaitForSeconds(Random.Range(timer1, timer2));
        sRenderer.sprite = laserBoom;
        laserSpeed = 0;

        if (isExpanding == true)
        {
            //Expand
            while(transform.localScale.x < 3)
            {
                isExpanding = false;
                transform.localScale = transform.localScale + new Vector3(0.1f, 0.1f, 0);
                yield return new WaitForSeconds(0.05f);
                Debug.Log("Is Expanding");
                
                
            }
        }
        
        if (isExpanding == false){
            
            while(transform.localScale.x >= 0.1f)
            {
                transform.localScale = transform.localScale - new Vector3(0.1f, 0.1f, 0);
                yield return new WaitForSeconds(0.05f);
                Debug.Log("Is Shrinking");

                //Shrink
            }

        }
        
        Destroy(gameObject);
        

        yield return null;
    }
}
