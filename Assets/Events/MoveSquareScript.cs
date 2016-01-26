using UnityEngine;
using System.Collections;

public class MoveSquareScript : MonoBehaviour {

	// Overload these so this script stops listening when disabled.
	void OnEnable() {
		ControllerInput.HorizontalJoyAxis += MoveSquare;
	}

	void OnDisable() {
		ControllerInput.HorizontalJoyAxis -= MoveSquare;
	}

	void MoveSquare(float newX) {
		Vector3 thePosition = gameObject.transform.position;
		thePosition.x = newX * 4;
		gameObject.transform.position = thePosition;
	}

}
