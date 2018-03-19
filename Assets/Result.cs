using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{

    public Text Red;
    public Text Blue;
    public Text Green;

    GameManager gameManager;
	// Use this for initialization
	void Start ()
    {
        gameManager = FindObjectOfType<GameManager>();
        Red.text = "Red: " + gameManager.RedCount;
        Blue.text = "Blue: " + gameManager.BlueCount;
        Green.text = "Green: " + gameManager.GreenCount;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
