using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleStealthSpot : MonoBehaviour
{
    public GameObject toggledGuards = null;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "PPlayer")
        {
            toggledGuards.SetActive(true);
            print("The guards came!!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "PPlayer")
        {
            toggledGuards.SetActive(false);
            print("The guards bounce");
        }
    }
}
