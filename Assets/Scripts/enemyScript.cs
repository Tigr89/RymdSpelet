using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class enemyScript : MonoBehaviour
{
    public float enemySpeed;
    public int enemyHP;
    public GameObject enemySpawner;
    public int enemyValue;
    public string deathMessage;

    //Death animation
    public Sprite[] explodeSprite;
    private SpriteRenderer sRenderer;
    public bool isExploding;


    // Start is called before the first frame update
    void Start()
    {
        enemySpawner = GameObject.Find("EnemySpawner").gameObject;
        sRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.down * enemySpeed * Time.deltaTime);

        if(transform.position.y <= -8)
        {
            transform.position = new Vector3(Random.Range(-8, 8), 5.5f, 0);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Laser")
        {
            Debug.Log("Test");
            enemyHP--;
            if (enemyHP <= 0)
            {
                enemySpawner.GetComponent<spawnerScript>().EnemyDeath(enemyValue, 1, deathMessage);
                
                if(isExploding == false)
                {
                    isExploding = true;
                    StartCoroutine(DeathAnimation());
                }
                
            }
        }
    }

    private IEnumerator DeathAnimation()
    {
        for(int i = 0; i < explodeSprite.Length; i++) 
        { 
            sRenderer.sprite = explodeSprite[i];
            yield return new WaitForSeconds(0.05f);
        }
        Destroy(gameObject);

        yield return null;
    }
}
