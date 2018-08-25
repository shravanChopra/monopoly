using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card
{
    private new string name;

    public Card(string cardName)
    { 
        this.name = cardName;
    }

    public string GetName()
    {
        return this.name;
    }
}
