using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakScript : MonoBehaviour
{
    public GameObject guards = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //When player walks on button
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PPlayer")
        {
            guards.SetActive(true);
        }
    }

    //When player leaves button
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PPlayer")
        {
            guards.SetActive(false);
        }
    }
}
