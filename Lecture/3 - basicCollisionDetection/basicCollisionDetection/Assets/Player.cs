using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //callback - special function that gets called whenever something special happens inside unity
    //start() is a callback whenever an object gets called into existence
    //update() is a callback that is called all the time
    //onCollissionEnter()
    void OnCollisionEnter(Collision other)
    {
        print(other.gameObject.name);
    }
    
}
