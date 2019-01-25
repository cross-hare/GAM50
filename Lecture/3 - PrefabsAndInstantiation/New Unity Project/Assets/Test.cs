using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//prefabs are creating versions of things you expect to be repeatably, ie. a template
//instatiating prefabs is creating an instance of that object at run time

public class Test : MonoBehaviour
{
    //Describing what we want to instantiate
    //Instantiation - Realization of a predefined object
    public GameObject prefab = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate (what you want to instantiate, where you want to instantiate, the rotation)        
        Instantiate(prefab, gameObject.transform.position, gameObject.transform.rotation);
    }
}
