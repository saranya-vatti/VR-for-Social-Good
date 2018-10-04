using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private int time;
    public Text moneyEarned;
    public Text timeLeft;
    private double money;

	// Use this for initialization
	void Start () {
        time = 8;
        timeLeft.text = "Time Left: " + timeLeft.ToString() + " hours";
        money = 0.0;
        moneyEarned.text = "Bank: $" + money.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void UpdateStats (int t, double m)
    {
        time = time - t;
        timeLeft.text = "Time Left: " + timeLeft.ToString() + " hours";
        money = m;
        moneyEarned.text = "Bank: $" + money.ToString();
    }
}
