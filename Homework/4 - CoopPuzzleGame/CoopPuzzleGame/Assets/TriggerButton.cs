using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerButton : MonoBehaviour
{
    //gameObject reference
    public GameObject toggledGridSpace = null;

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
        if (other.gameObject.tag == "Player")
        {
            toggledGridSpace.SetActive(true);
        }
    }

    //When player leaves button
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            toggledGridSpace.SetActive(false);
        }
    }
}
