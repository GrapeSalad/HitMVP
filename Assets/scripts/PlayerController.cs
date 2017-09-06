using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	float number = 0;
	public float thrust;
	public GameObject one;
	public GameObject two;
	public Rigidbody rbWeight { get; private set; }
	public Rigidbody rbDemoBall { get; private set; }

	// Use this for initialization
	void Start () {
		one = GameObject.Find ("Weight");
		two = GameObject.Find ("Player");
		rbWeight = one.GetComponent<Rigidbody> ();
		rbDemoBall = two.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		float moveVertical = Input.GetAxis("Vertical");
		if (Input.GetKey (KeyCode.Space)) {
			number -= 1;
			print ("The amount of force to add is: " + number);
			
		}
		if (Input.GetKeyUp (KeyCode.Space)) {
			rbWeight.useGravity = true;
			rbDemoBall.useGravity = true;
			rbWeight.AddForce (0, number, 0, ForceMode.Force);
		}
	}
}
