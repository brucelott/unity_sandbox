using UnityEngine;
using System.Collections;

public class ControllerBroadcaster : MonoBehaviour {

	public delegate void ButtonDown();
	public static event ButtonDown OnJump;

	public delegate void JoyAxis(float val);
	public static event JoyAxis HorizontalJoyAxis;

	void Update () {
		// Jump 
		if(Input.GetButtonDown("Jump")) {
			// Don't send message if noone is listening.
			if(OnJump != null) {
				OnJump();
			}
		}

		// Horizontal joystick axis
		if(HorizontalJoyAxis != null) {
			float horizontalMove = Input.GetAxis("Horizontal");
			HorizontalJoyAxis(horizontalMove);	
		}	
	}

}
