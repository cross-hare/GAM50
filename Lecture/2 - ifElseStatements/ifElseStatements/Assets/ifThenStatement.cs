using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifThenStatement : MonoBehaviour
{
    public int myAge = 22;

    // Start is called before the first frame update
    void Start()
    {
        if (myAge > 18)
        {
            Debug.Log("I am an adult");
        }
        else if (myAge < 5)
        {
            Debug.Log("I am a wee laddie");
        }
        else
        {
            Debug.Log("Invalid");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
