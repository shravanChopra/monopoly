using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int boardPosition; 

	// Use this for initialization
	void Start ()
    {
        this.boardPosition = 0;                // always start at GO
	}
	
	// Update is called once per frame
	void Update ()
    {
		// do your magic...
	}

    // Game Manager is responsible for computing new position and assigning to the player
    public void MoveTo(int newPosition)
    {
        this.boardPosition = newPosition;
    }

    public int GetPosition()
    {
        return this.boardPosition;
    }
}
