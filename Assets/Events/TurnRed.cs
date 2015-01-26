using UnityEngine;
using System.Collections;

public class ColorScript : MonoBehaviour {

	SpriteRenderer renderer;

	// Overload these so this script stops listening when disabled.
	void OnEnable() {
		// Call FlipColor() when OnJump event is received.
		ControllerInput.OnJump += FlipColor;
	}

	void OnDisable() {
		ControllerInput.OnJump -= FlipColor;
	}

	// Grap the sprite renderer.
	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}

	// Flip sprite renderer between red and black.
	void FlipColor() {
		if(renderer.color == Color.red)
			renderer.color = Color.black;
		else 
			renderer.color = Color.red;
	}
	
}
