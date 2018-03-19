using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public int RedCount = 0;
    public int BlueCount = 0;
    public int GreenCount = 0;

    public bool GameStarted;

    public Text Timer;
    float timer = 30f;

	void Awake ()
    {
        DontDestroyOnLoad(gameObject);	
	}
	
	void Update ()
    {
        if (GameStarted)
        {
            timer -= Time.deltaTime;
            Timer.text = "Time: " + timer.ToString("N2") + "s";
            if (timer <= 0)
            {
                Timer.text = "Time: 0.00s";
                GameStarted = false;
                SceneManager.LoadScene("Result");
            }
        }
	}

    public void StartGame()
    {
        GameStarted = true;
    }

    public void PickedUp(PickupType pickupType)
    {
        switch (pickupType)
        {
            case PickupType.Red:
                RedCount++;
                break;
            case PickupType.Blue:
                BlueCount++;
                break;
            case PickupType.Green:
                GreenCount++;
                break;
            default:
                break;
        }
    }
}
