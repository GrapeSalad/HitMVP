using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TextControl;

public class WinScript : MonoBehaviour {

	private GameObject hideMVPAtStart;
	private GameObject hideFireWorksAtStart;
	// Use this for initialization
	void Start () {
		hideMVPAtStart = GameObject.Find ("MVP");
		hideFireWorksAtStart = GameObject.Find ("Fireworks");
		hideMVPAtStart.gameObject.SetActive (false);
		hideFireWorksAtStart.gameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnTriggerEnter(Collider other)
	{
		if(other.CompareTag("Player"))
		{
			print("enter");
			hideMVPAtStart.gameObject.SetActive (true);
			hideFireWorksAtStart.gameObject.SetActive (true);
		}
	}
}
