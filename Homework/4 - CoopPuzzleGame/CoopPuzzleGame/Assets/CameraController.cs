//allows camera to follow player around
//utilizes CameraDock dempty game object
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    //make class know about CameraDock gameobject
    public GameObject cameraDock = null;
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //lerp - linear interpolation - overtime moving from one place to another, makes smooth camera movement
        transform.position = Vector3.Lerp(transform.position, cameraDock.transform.position, Time.deltaTime * speed);
    }
}
