using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// TODO: consider reverting this to a C# singleton
public class Board: MonoBehaviour
{
    private static Board pInstance = null;             
    private Dictionary<int, Card> gameCards;

    void Awake()
    {
        if (pInstance == null)
        {
            pInstance = this;
            this.gameCards = new Dictionary<int, Card>();
        }
        else
        {
            Destroy(this.gameObject);
        }

        // Safety - have this persist between scenes (or when reloading this scene)
        DontDestroyOnLoad(this.gameObject);
    }

    void Start()
    {
        this.PrivAddGameCards();
    }

    void Update()
    {
        // do your magic
    }

    public static Card GetCardAt(int boardIndex)
    {
        Board pBoard = Board.PrivGetInstance();
        Card pCard = null;

        // actually, this should NEVER fail (consider removing)!
        if (pBoard.gameCards.ContainsKey(boardIndex))
        {
            pCard = pBoard.gameCards[boardIndex];
        }

        return pCard;
    }

    private void PrivAddGameCards()
    {
        // bottom row 
        this.gameCards.Add(0, new Card("GO"));
        this.gameCards.Add(1, new Card("Mediterranean Avenue"));
        this.gameCards.Add(2, new Card("Community Chest"));
        this.gameCards.Add(3, new Card("Baltic Avenue"));
        this.gameCards.Add(4, new Card("Income Tax"));
        this.gameCards.Add(5, new Card("Reading Railroad"));
        this.gameCards.Add(6, new Card("Oriental Avenue"));
        this.gameCards.Add(7, new Card("CHANCE"));
        this.gameCards.Add(8, new Card("Vermont Avenue"));
        this.gameCards.Add(9, new Card("Connecticut Avenue"));

        // left row
        this.gameCards.Add(10, new Card("JAIL"));
        this.gameCards.Add(11, new Card("St. Charles Place"));
        this.gameCards.Add(12, new Card("ELECTRIC COMPANY"));
        this.gameCards.Add(13, new Card("States Avenue"));
        this.gameCards.Add(14, new Card("Virginia Avenue"));
        this.gameCards.Add(15, new Card("Pennsylvania Railroad"));
        this.gameCards.Add(16, new Card("St. James Place"));
        this.gameCards.Add(17, new Card("COMMUNITY CHEST"));
        this.gameCards.Add(18, new Card("Tennessee Avenue"));
        this.gameCards.Add(19, new Card("New York Avenue"));

        // top row
        this.gameCards.Add(20, new Card("FREE PARKING"));
        this.gameCards.Add(21, new Card("Kentucky Avenue"));
        this.gameCards.Add(22, new Card("CHANCE"));
        this.gameCards.Add(23, new Card("Indiana Avenue"));
        this.gameCards.Add(24, new Card("Illinois Avenue"));
        this.gameCards.Add(25, new Card("B & O Railroad"));
        this.gameCards.Add(26, new Card("Atlantic Avenue"));
        this.gameCards.Add(27, new Card("Ventnor Avenue"));
        this.gameCards.Add(28, new Card("WATER WORKS"));
        this.gameCards.Add(29, new Card("Marvin Gardens"));

        // right row
        this.gameCards.Add(30, new Card("GO TO JAIL"));
        this.gameCards.Add(31, new Card("Pacific Avenue"));
        this.gameCards.Add(32, new Card("North Carolina Avenue"));
        this.gameCards.Add(33, new Card("COMMUNITY CHEST"));
        this.gameCards.Add(34, new Card("Pennsylvania Avenue"));
        this.gameCards.Add(35, new Card("Short Line"));
        this.gameCards.Add(36, new Card("CHANCE"));
        this.gameCards.Add(37, new Card("Park Place"));
        this.gameCards.Add(38, new Card("LUXURY TAX"));
        this.gameCards.Add(39, new Card("Boardwalk"));
    }

    private static Board PrivGetInstance()
    {
        Debug.Assert(pInstance != null);
        return pInstance;
    }

    // Mostly for debugging ==> TODO: remove this!
    public static void PrintCards()
    {
        Board pBoard = Board.PrivGetInstance();

        foreach (int index in pBoard.gameCards.Keys)
        {
            Debug.Log("CARD: " + pBoard.gameCards[index].GetName());
        }
    }
}
