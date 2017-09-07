using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace TextControl
{
	public class TextController : MonoBehaviour {

		public Text text;
		void Start(){
			text.text = "Press and Hold The Space Bar to add downward force to the smaller ball";
		}
		void FixedUpdate(){
			if (Input.GetKey (KeyCode.Space)) {
				text.text = "Hold till you are ready to launch!";
			}
			if (Input.GetKeyUp (KeyCode.Space)) {
				text.text = "Onwards! To Try again Press 'R'";
			}
			if (Input.GetKeyDown (KeyCode.R)) {
				SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
			
			}
		}
//		private enum States {play, win};
//		private States myState;
//
//		// Use this for initialization
//		void Start () {
//			myState = States.play;
//		}
//		
//		// Update is called once per frame
//		void Update () {
//			if (myState == States.play) {
//				state_space ();
//			}else if(myState == States.win){
//				state_enter ();
//			}
//		}
//		public void state_space()
//		{
//			text.text = "Launch The Ball!";
//			if (Input.GetKeyDown (KeyCode.Space)) {
//				myState = States.win;
//			}
//		}
//		void state_enter()
//		{
//			text.text = "Press Enter";
//			if (Input.GetKeyDown (KeyCode.Return)) {
//				myState = States.play;
//			}
//		}
	}
}