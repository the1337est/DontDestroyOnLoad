using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


    GameManager gm;
	// Use this for initialization
	void Start () {
        gm = FindObjectOfType<GameManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (gm.GameStarted)
        {
            transform.position += Vector3.up * Input.GetAxis("Vertical") * Time.deltaTime;
            transform.position += Vector3.right * Input.GetAxis("Horizontal") * Time.deltaTime;
        }
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Pickup")
        {
            gm.PickedUp(collision.GetComponent<Pickup>().Type);
            Destroy(collision.gameObject);
        }
    }
}
