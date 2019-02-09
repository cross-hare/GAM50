using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode upInput = KeyCode.UpArrow;
    public KeyCode downInput = KeyCode.DownArrow;
    public float speed = 10.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        var vel = rb.velocity;

        //uses rigid body components in order to create paddle movement
        if (Input.GetKeyDown(upInput))
        {
            transform.Translate(Vector3.up);
        }
        if (Input.GetKeyDown(downInput))
        {
            transform.Translate(Vector3.down);
        }

        float botBound = -2.25f;
        float topBound = 4.10f;
        var pos = transform.position;

        if (pos.y > topBound)
        {
            pos.y = topBound;
        }
        else if (pos.y < botBound)
        {
            pos.y = botBound;
        }
        transform.position = pos;
    }
}

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public KeyCode upInput = KeyCode.UpArrow;
    public KeyCode downInput = KeyCode.DownArrow;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(upInput))
        {
            transform.Translate(Vector3.up);
        }
        if (Input.GetKeyDown(downInput))
        {
            transform.Translate(Vector3.down);
        }
    }
}*/

