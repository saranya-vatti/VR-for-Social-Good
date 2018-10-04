using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private string timeLeft;
    private Text moneyEarned;
    private double money;

	// Use this for initialization
	void Start () {
        timeLeft = "08:00 hours";
        money = 0.0;
        moneyEarned.text = "Bank: $" + money.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
