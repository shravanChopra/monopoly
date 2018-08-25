using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Player player1;
    private Player pActivePlayer;

	// Use this for initialization
	void Start ()
    {
        pActivePlayer = player1;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    public void RollDiceAndMovePlayer()
    {
        int diceRoll = Random.Range(1, 7);
        int newPosition = pActivePlayer.GetPosition() + diceRoll;

        // wrap around...
        if (newPosition >= 40)
        {
            newPosition %= 40;
        }

        pActivePlayer.MoveTo(newPosition);

        // TODO: start the player's turn and switch to the next one
    }
}
