//everything associated with player control
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;
    //goal - instantiate a projectile at the placement of each of these weapons whenever a player presses a key
    public GameObject[] weaponsPlacements;
    public GameObject laserPrefab = null;
    public GameObject shield = null;
    public bool isUsingShield = false;

    // Start is called before the first frame update
    void Start()
    {
        shield.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey (KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.up * Time.deltaTime * speed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down * Time.deltaTime * speed);
        }
     
        if (Input.GetKeyDown(KeyCode.Space))
        {
            foreach (GameObject weaponPlacement in weaponsPlacements)
            {
                Instantiate(laserPrefab, weaponPlacement.transform.position, weaponPlacement.transform.rotation);
            }
        }

        if (Input.GetKeyDown (KeyCode.LeftShift))
        {
            shield.SetActive(true);
            isUsingShield = true;
        }
        if(Input.GetKeyUp (KeyCode.LeftShift))
        {
            shield.SetActive(false);
            isUsingShield = false;
        }

        void OnCollisionEnter(Collision other)
        {
            if (isUsingShield == true)
            {
                //don't take damage
            }
            else
            {
                 //take damage
            }
        }
    }//end of void update()         
}//end of PlayerController
