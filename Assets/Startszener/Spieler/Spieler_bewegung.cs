using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spieler_bewegung : MonoBehaviour {

    public float speed = 5f;
    Rigidbody myRigidbody;

	// Use this for initialization
	void Start () {
        myRigidbody = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveVertical = Input.GetAxis("Vertical");
        float moveHorizontal = Input.GetAxis("Horizontal");
        Vector3 movment = new Vector3(moveHorizontal, 0f, moveVertical);
        myRigidbody.AddForce(movment * speed);
	}
}
