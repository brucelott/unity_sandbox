using UnityEngine;
using System.Collections;

public class ControllerInput : MonoBehaviour {

	public delegate void ButtonDown();
	public static event ButtonDown OnJump;

	void Update () {
		if(Input.GetButtonDown("Jump")) {
			// Don't send message if noone is listening.
			if(OnJump != null) {
				OnJump();
			}
		}
	}

}
