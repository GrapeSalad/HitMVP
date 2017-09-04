using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TextControl
{
	public class TextController : MonoBehaviour {

		public Text text;
		private enum States {play, win};
		private States myState;

		// Use this for initialization
		void Start () {
			myState = States.play;
		}
		
		// Update is called once per frame
		void Update () {
			if (myState == States.play) {
				state_space ();
			}else if(myState == States.win){
				state_enter ();
			}
		}
		public void state_space()
		{
			text.text = "Launch The Ball!";
			if (Input.GetKeyDown (KeyCode.Space)) {
				myState = States.win;
			}
		}
		void state_enter()
		{
			text.text = "Press Enter";
			if (Input.GetKeyDown (KeyCode.Return)) {
				myState = States.play;
			}
		}
	}
}