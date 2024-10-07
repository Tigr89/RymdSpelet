using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerSpawnScript : MonoBehaviour
{

    public GameObject player;
    public int playerLives;
    public int playerMaxLives;
    public float spawnDelay;

    // Start is called before the first frame update
    void Start()
    {
        playerLives = playerMaxLives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator playerSpawner()
    {
        while (true)
        {
            if (GameObject.Find("player") == null)
            {

                yield return new WaitForSeconds(spawnDelay);
                Debug.Log("Player lives: " + playerLives);
                Instantiate(player);
            }
            else yield return null;
        }
    }

}
