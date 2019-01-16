using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{   
    //GameObjects are stores as references, as opposed to values
    //initializing as null means it isn't pointing to anything
    public GameObject player = null;
    public int health = 20;

    // Start is called before the first frame update
    void Start()
    {
        player.GetComponent<Player>().health = 90;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
