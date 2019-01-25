using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public KeyCode upInput = KeyCode.UpArrow;
    public KeyCode downInput = KeyCode.DownArrow;
    public KeyCode leftInput = KeyCode.LeftArrow;
    public KeyCode rightInput = KeyCode.RightArrow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        if (Input.GetKeyDown (upInput))
        {
            transform.Translate(Vector3.forward);
        }
        if (Input.GetKeyDown(downInput))
        {
            transform.Translate(Vector3.back);
        }
        if (Input.GetKeyDown(leftInput))
        {
            transform.Translate(Vector3.left);
        }
        if (Input.GetKeyDown(rightInput))
        {
            transform.Translate(Vector3.right);
        }
    }
}
