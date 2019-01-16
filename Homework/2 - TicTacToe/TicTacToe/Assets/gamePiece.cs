using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamePiece : MonoBehaviour
{
    public GameObject gameManager = null;
    public bool isAvailable = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        print(gameObject.name);

        if (isAvailable == true)
        {
            //renderer is responsible for drawing objects
            //material controls image properties of a 3D object
            //notice everytime we use the dot operator things get more specific
            if (gameManager.GetComponent<gameManager>().isPlayer1Turn == true)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.blue;
                if (gameObject.name == "A1")
                {
                    gameManager.GetComponent<gameManager>().a1Player1 = true;
                }
                if (gameObject.name == "B1")
                {
                    gameManager.GetComponent<gameManager>().b1Player1 = true;
                }
                if (gameObject.name == "C1")
                {
                    gameManager.GetComponent<gameManager>().c1Player1 = true;
                }
                if (gameObject.name == "A2")
                {
                    gameManager.GetComponent<gameManager>().a2Player1 = true;
                }
                if (gameObject.name == "B2")
                {
                    gameManager.GetComponent<gameManager>().b2Player1 = true;
                }
                if (gameObject.name == "C2")
                {
                    gameManager.GetComponent<gameManager>().c2Player1 = true;
                }
                if (gameObject.name == "A3")
                {
                    gameManager.GetComponent<gameManager>().a3Player1 = true;
                }
                if (gameObject.name == "B3")
                {
                    gameManager.GetComponent<gameManager>().b3Player1 = true;
                }
                if (gameObject.name == "C3")
                {
                    gameManager.GetComponent<gameManager>().c3Player1 = true;
                }
            }
            else if (gameManager.GetComponent<gameManager>().isPlayer2Turn == true)
            {
                gameObject.GetComponent<Renderer>().material.color = Color.red;
                if (gameObject.name == "A1")
                {
                    gameManager.GetComponent<gameManager>().a1Player2 = true;
                }
                if (gameObject.name == "B1")
                {
                    gameManager.GetComponent<gameManager>().b1Player2 = true;
                }
                if (gameObject.name == "C1")
                {
                    gameManager.GetComponent<gameManager>().c1Player2 = true;
                }
                if (gameObject.name == "A2")
                {
                    gameManager.GetComponent<gameManager>().a2Player2 = true;
                }
                if (gameObject.name == "B2")
                {
                    gameManager.GetComponent<gameManager>().b2Player2 = true;
                }
                if (gameObject.name == "C2")
                {
                    gameManager.GetComponent<gameManager>().c2Player2 = true;
                }
                if (gameObject.name == "A3")
                {
                    gameManager.GetComponent<gameManager>().a3Player2 = true;
                }
                if (gameObject.name == "B3")
                {
                    gameManager.GetComponent<gameManager>().b3Player2 = true;
                }
                if (gameObject.name == "C3")
                {
                    gameManager.GetComponent<gameManager>().c3Player2 = true;
                }
            }
            isAvailable = false;
            gameManager.GetComponent<gameManager>().TurnWasTaken();
        }
    }
}
