//determines if feeler is on a valid tilespace for the Thief class
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Feeler : MonoBehaviour
{
    public bool isValid = false;
    public bool isObstacle = false;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Renderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Guard")
        {
            isObstacle = true;
            isValid = false;
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            print("Stopped by a guard!");
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            isObstacle = true;
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            print("Hit a wall!");
        }
        else if (other.gameObject.tag == "GridSpace" && isObstacle == false)
        {
            isValid = true;
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Guard")
        {
            isObstacle = false;
            isValid = true;
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (other.gameObject.tag == "Obstacle")
        {
            isObstacle = false;
            gameObject.GetComponent<Renderer>().enabled = true;
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
        else if (other.gameObject.tag == "GridSpace")
        {
            isValid = false;
            gameObject.GetComponent<Renderer>().enabled = false;
            gameObject.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
