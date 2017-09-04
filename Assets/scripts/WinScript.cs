using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextControl;

public class WinScript : MonoBehaviour {

	private GameObject hideAtStart;
	// Use this for initialization
	void Start () {
		hideAtStart = GameObject.Find ("MVP");
		hideAtStart.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			print("enter");
			hideAtStart.gameObject.SetActive (true);
		}
	}
}
