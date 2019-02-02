using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab = null;
    public GameObject[] enemySpawnPoint;
    public float spawnDelay = 3.0f;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnDelay)
        {
            Instantiate(enemyPrefab, transform.position, transform.rotation);
            timer = 0.0f;
        }
    }
}
