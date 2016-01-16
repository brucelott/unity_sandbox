// using UnityEngine;
// using System.Collections;

// public class PlayerAnimator : MonoBehaviour {

// 	public SpriteRenderer renderer;

// 	void Start() {
// 		renderer = GetComponent<SpriteRenderer>();
// 	}

// 	void OnEnable() {
// 		PlayerController.OnChangeDirection += FlipRenderer;
// 	}

// 	void OnDisable() {
// 		PlayerController.OnChangeDirection -= FlipRenderer;
// 	}

// 	private void FlipRenderer(bool facingRight) {
// 		int direction;
// 		if(facingRight)
// 			direction = 1;
// 		else
// 			direction = -1; 

// 		Vector3 localScale = transform.localScale;
// 		localScale.x *= direction;
// 		transform.localScale = localScale;
// 	}

// }
