using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    //GameObjects are stores as references, as opposed to values
    //initializing as null means it isn't pointing to anything
    //always name lowercase so that there is avoided confusion between type name and variable name
    public GameObject enemy = null;
    public int health = 100;

    // Start is called before the first frame update
    void Start()
    {
        //If you want to get any component from a gameObject that you have reference to
        enemy.GetComponent<Enemy>().health = 10; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
