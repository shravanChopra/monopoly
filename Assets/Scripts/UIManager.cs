using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private static UIManager pInstance = null;

    // Pre-turn UI
    [SerializeField] private GameObject diceRollBtn;

    // Turn UI
    [SerializeField] private GameObject endTurnBtn;

    // Make this a singleton
    private void Awake()
    {
        if (pInstance == null)
        {
            pInstance = this;
        }
        else
        {
            Destroy(this.gameObject);
        }

        // persist between scene loading
        DontDestroyOnLoad(this.gameObject);
    }

    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private static UIManager PrivGetInstance()
    {
        Debug.Assert(pInstance != null);
        return pInstance;
    }

    public static void DisplayPreTurnUI()
    {
        UIManager pMan = UIManager.PrivGetInstance();
       
        pMan.diceRollBtn.SetActive(true);
        pMan.endTurnBtn.SetActive(false);
    }

    public static void DisplayTurnUI()
    {
        UIManager pMan = UIManager.PrivGetInstance();

        pMan.endTurnBtn.SetActive(true);
        pMan.diceRollBtn.SetActive(false);
    }
}
