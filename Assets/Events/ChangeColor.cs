using UnityEngine;
using System.Collections;

public class ChangeColor : MonoBehaviour {

	SpriteRenderer renderer;

	// Overload these so this script stops listening when disabled.
	void OnEnable() {
		ControllerInput.OnJump += FlipColor;
	}

	void OnDisable() {
		ControllerInput.OnJump -= FlipColor;
	}

	void Start () {
		renderer = GetComponent<SpriteRenderer>();
	}

	void FlipColor() {
		if(renderer.color == Color.red)
			renderer.color = Color.black;
		else 
			renderer.color = Color.red;
	}
	
}
