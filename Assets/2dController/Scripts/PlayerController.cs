using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	public float maxSpeed = 10f;
	public float jumpForce = 300f;
	bool isFacingRight = true;
	bool isGrounded = true;
	Animator animator;

	public delegate void Trigger();
	public static event Trigger OnJump;
	public static event Trigger OnLanding;

	void Start() {
		animator = GetComponent<Animator>();
	}

	void Update() {
		// Check if character landed on the ground.
		if(!isGrounded && rigidbody2D.velocity.y == 0)
			Land();

		/* Controller Input */
		// Jump.
		if(Input.GetButtonDown("Jump"))
			Jump();		

		// Joystick X Axis.
		float horizontalMove = Input.GetAxis("Horizontal");
		rigidbody2D.velocity = new Vector2(horizontalMove * maxSpeed, 
																			 rigidbody2D.velocity.y);
	}

	void FixedUpdate() {
		float horizontalMove = Input.GetAxis("Horizontal");
		// Flip character direction if necessary.
		if(horizontalMove > 0 && !isFacingRight)
			ChangeDirection();
		else if(horizontalMove < 0 && isFacingRight)
			ChangeDirection();

		// Play the walk or idle animation.
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
	}

	private void ChangeDirection() {
		isFacingRight = !isFacingRight;
		Vector3 localScale = transform.localScale;
		localScale.x *= -1;
		transform.localScale = localScale;
	}

	public void Jump() { 
		if(isGrounded) {	
			rigidbody2D.AddForce(transform.up * jumpForce); 
			isGrounded = false;
			animator.SetTrigger("Jump");
			if(OnJump != null)
				OnJump();
		}
	}

	public void Land() {
		isGrounded = true;
		if(OnLanding != null)
			OnLanding();
	}
}
