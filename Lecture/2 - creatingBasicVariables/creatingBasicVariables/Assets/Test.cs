using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //(public)ACCESSOR LEVEL ... (int)DATA TYPE ... (myInt)NAME OF VARIABLE/CAMEL CASE...(0)VALUE
    public int myInt = 0;
    public float myFloat = 0.0f;
    public bool myBool = false;
    public string myString = "";

    public string dudeName = "";
    public string weapon = "";

    // Start is called before the first frame update
    void Start()
    {
        print(dudeName + " has just equiped " + weapon);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
