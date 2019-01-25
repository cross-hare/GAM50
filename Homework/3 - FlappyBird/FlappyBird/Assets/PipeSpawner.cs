//Spawns pipes
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    //What we want to instatiate (The pipes)
    public GameObject prefab = null;
    public float spawnDelay = 1.0f;
    public float timer = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Replace existing value of timer with the old value of timer + the ammount of time that
        //has changed since the last frame
        timer += Time.deltaTime;
        if (timer >= spawnDelay)
        {
            //Creating pipePair prefab at the position and rotation of our gameObject
            Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
            //reset timer back to 0 in order to make it so timer is >= spawnDelay again
            timer = 0.0f;
        }
    }
}
