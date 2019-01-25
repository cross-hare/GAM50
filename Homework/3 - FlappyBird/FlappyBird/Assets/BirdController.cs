//Script to controls movement of player
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float force = 100.0f;
    //Unity sets default gravity pulls down at a rate of ~9.8 force
    //Need to switch unity gravity and float force around in order to recreate the original flappy bird

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown (KeyCode.Space))
        {
            //Resets velocity at the beginning of every frame
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            //When user presses space, birb goes up by our force variable
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
        }
    }

    void OnCollisionEnter (Collision other)
    {
        if (other.gameObject.tag == "Ground")
        {
            print("Death by ground");
            SceneManager.LoadScene("FlappyBird");
        }

        if(other.gameObject.tag == "Pipe")
        {
            print("Death by pipe");
            SceneManager.LoadScene("FlappyBird");
        }
    }
}
