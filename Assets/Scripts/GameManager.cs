using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // TODO: convert this to a Unity singleton

    // Data
    private int NUM_PLAYERS = 2;            // Ideally, this should be assigned BEFORE the game starts (gets into the Game scene)
    private Player[] players;
    private Player pActivePlayer;
    private int activePlayerIndex;
   
	// Use this for initialization
	void Start ()
    {
        this.players = new Player[NUM_PLAYERS];
        this.PrivSetupPlayers();

        // p1 starts
        activePlayerIndex = 0;
        pActivePlayer = this.players[activePlayerIndex];           
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void RollDiceAndMovePlayer()
    {
        int diceRoll = Random.Range(1, 7);                                  // TODO: extend to two dice!
        Debug.Log("==============> Dice outcome: " + diceRoll);

        int newPosition = pActivePlayer.GetPosition() + diceRoll;

        // wrap around...
        if (newPosition >= 40)
        {
            newPosition %= 40;
        }

        pActivePlayer.MoveTo(newPosition);

        // TODO: start the player's turn
    }

    public void EndCurrentTurnAndSwitchToNextPlayer()
    {
        // TODO: flip the current player to 'READY'

        this.PrivPrepareNextPlayer();

        this.PrivLogPlayerPositions();
    }

    private void PrivPrepareNextPlayer()
    {
        this.activePlayerIndex++;

        // wrap around...
        if (this.activePlayerIndex == this.NUM_PLAYERS)
        {
            this.activePlayerIndex = 0;
        }

        this.pActivePlayer = this.players[activePlayerIndex];
    }

    // This needs to be done because we have an array of pointers ==> they still need to point to something 
    private void PrivSetupPlayers()
    {
        for (int i = 0; i < NUM_PLAYERS; i++)
        {
            Player pPlayer = new Player();
            this.players[i] = pPlayer;
        }
    }

    // Log all positions ==> mostly for debugging (TODO: remove this!)
    private void PrivLogPlayerPositions()
    {
        for (int i = 0; i < this.NUM_PLAYERS; i++)
        {
            Debug.Log("Player " + (i + 1) + " at card " + Board.GetCardAt(this.players[i].GetPosition()).GetName());
        }
    }
}
