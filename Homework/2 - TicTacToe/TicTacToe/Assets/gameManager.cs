using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
   
    public bool isPlayer1Turn = true;
    public bool isPlayer2Turn = false;

    public bool a1Player1 = false;
    public bool a2Player1 = false;
    public bool a3Player1 = false;
    public bool b1Player1 = false;
    public bool b2Player1 = false;
    public bool b3Player1 = false;
    public bool c1Player1 = false;
    public bool c2Player1 = false;
    public bool c3Player1 = false;

    public bool a1Player2 = false;
    public bool a2Player2 = false;
    public bool a3Player2 = false;
    public bool b1Player2 = false;
    public bool b2Player2 = false;
    public bool b3Player2 = false;
    public bool c1Player2 = false;
    public bool c2Player2 = false;
    public bool c3Player2 = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Player 1 Win Conditions
        //Horizontal
        if (a1Player1 == true && a2Player1 == true && a3Player1 == true)
        {
            print("Player 1 Wins!");
        }
        if (b1Player1 == true && b2Player1 == true && b3Player1 == true)
        {
            print("Player 1 Wins!");
        }
        if (c1Player1 == true && c2Player1 == true && c3Player1 == true)
        {
            print("Player 1 Wins!");
        }
        //Vertical
        if (a1Player1 == true && b1Player1 == true && c1Player1 == true)
        {
            print("Player 1 Wins!");
        }
        if (a2Player1 == true && b2Player1 == true && c2Player1 == true)
        {
            print("Player 1 Wins!");
        }
        if (a3Player1 == true && b3Player1 == true && c3Player1 == true)
        {
            print("Player 1 Wins!");
        }
        //Diagonal
        if (a3Player1 == true && b2Player1 == true && c1Player1 == true)
        {
            print("Player 1 Wins!");
        }
        if (a1Player1 == true && b2Player1 == true && c3Player1 == true)
        {
            print("Player 1 Wins!");
        }

        //Player 2 Win Conditions
        //Horizontal
        if (a1Player2 == true && a2Player2 == true && a3Player2 == true)
        {
            print("Player 2 Wins!");
        }
        if (b1Player2 == true && b2Player2 == true && b3Player2 == true)
        {
            print("Player 2 Wins!");
        }
        if (c1Player2 == true && c2Player2 == true && c3Player2 == true)
        {
            print("Player 2 Wins!");
        }
        //Vertical
        if (a1Player2 == true && b1Player2 == true && c1Player2 == true)
        {
            print("Player 2 Wins!");
        }
        if (a2Player2 == true && b2Player2 == true && c2Player2 == true)
        {
            print("Player 2 Wins!");
        }
        if (a3Player2 == true && b3Player2 == true && c3Player2 == true)
        {
            print("Player 2 Wins!");
        }
        //Diagonal
        if (a3Player2 == true && b2Player2 == true && c1Player2 == true)
        {
            print("Player 2 Wins!");
        }
        if (a1Player2 == true && b2Player2 == true && c3Player2 == true)
        {
            print("Player 2 Wins!");
        }

    }

    public void TurnWasTaken()
    {
        if (isPlayer1Turn == true)
        {
            isPlayer1Turn = false;
            isPlayer2Turn = true;
        }
        else if (isPlayer2Turn == true)
        {
            isPlayer2Turn = false;
            isPlayer1Turn = true;
        }
    }
}
