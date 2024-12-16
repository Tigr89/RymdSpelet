using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(enemy);
        StartCoroutine(SpawnTimer());
    }

    // Update is called once per frame
    void Update()
    {

    }
    private IEnumerator SpawnTimer() // Var fjärde sekund ska en fiende spawn in
    {
        
        yield return new WaitForSeconds(2);
        Instantiate(enemy);
        yield return null;
        StartCoroutine(SpawnTimer());
    }
}

