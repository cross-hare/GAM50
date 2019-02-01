//arrays are good for storing a bunch of elements in a singular variable
//arrays can be any data type, including data types you yourself create (such as GameObjects)
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public string[] screenNames;

    // Start is called before the first frame update
    void Start()
    {
        //one of the problems with arrays is ambiguity. You have one variable that potentially stores a bunch of different values.
        //print(screenNames) would not work.
        //screenNames[1] would print the first index/element of the screenNames array
        print(screenNames[1]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
