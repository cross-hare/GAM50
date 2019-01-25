//Script that moves pipe pairs to the left
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipePair : MonoBehaviour
{
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time.deltaTime - Keeps everything in sync so that way program is consistent for 
        //any type of device
        //It represents the time difference between two frames 
        //(For fast computers, Time.deltaTime is tiny. For slow magines, it is large.)
        gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }
}
