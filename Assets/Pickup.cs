using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{

    public PickupType Type;

    SpriteRenderer rend;

    GameManager gm;
	// Use this for initialization
	void Start ()
    {
        gm = FindObjectOfType<GameManager>();
        rend = GetComponent<SpriteRenderer>();
        switch (Type)
        {
            case PickupType.Red:
                rend.color = Color.red;
                break;
            case PickupType.Blue:
                rend.color = Color.blue;
                break;
            case PickupType.Green:
                rend.color = Color.green;
                break;
            default:
                break;
        }
    }

}

public enum PickupType
{
    Red,
    Blue,
    Green
}
