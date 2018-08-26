using System.Collections;
using System.Collections.Generic;

public class Player
{
    private int boardPosition; 

	public Player()
    {
        this.boardPosition = 0;
    }

    // Game Manager is responsible for computing new position and assigning to the player
    public void MoveTo(int newPosition)
    {
        this.boardPosition = newPosition;
    }

    public void Update()
    {
        // update based on the current state
    }

    public int GetPosition()
    {
        return this.boardPosition;
    }
}
