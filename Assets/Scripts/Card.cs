using System.Collections;
using System.Collections.Generic;

public class Card
{
    private string name;

    public Card(string cardName)
    { 
        this.name = cardName;
    }

    public string GetName()
    {
        return this.name;
    }
}
