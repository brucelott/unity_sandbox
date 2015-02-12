/* using UnityEngine; */
/* using System.Collections; */

/* public class PlayerController : MonoBehaviour { */
/* 	public float maxSpeed = 10f; */
/* 	public float jumpForce = 300f; */
/* 	private float horizontalMove = 0; */
/* 	bool isFacingRight = true; */
/* 	bool isGrounded = true; */
/* 	Animator animator; */

/* 	void Start() { */
/* 		animator = GetComponent<Animator>(); */
/* 	} */

/* 	void Update() { */
/* 		// Check if character is on the ground. */
/* 		if(!isGrounded && rigidbody2D.velocity.y == 0) */
/* 			isGrounded = true; */

/* 		/1* Controller Input *1/ */
/* 		// Jump. */
/* 		if(Input.GetButtonDown("Jump")) { */
/* 	  	Jump(); */		
/* 			animator.SetTrigger("Jump"); */
/* 		} */
/* 		// X Axis Joystick Movement. */
/* 		horizontalMove = Input.GetAxis("Horizontal"); */
/* 		rigidbody2D.velocity = new Vector2(horizontalMove * maxSpeed, */ 
/* 																			 rigidbody2D.velocity.y); */
/* 	} */

/* 	void FixedUpdate() { */
/* 		// Play the walk or idle animation. */
/* 		animator.SetFloat("Speed", Mathf.Abs(horizontalMove)); */

/* 		// Flip character direction if necessary. */
/* 		if(horizontalMove > 0 && !isFacingRight) */
/* 			ChangeDirection(); */
/* 		else if(horizontalMove < 0 && isFacingRight) */
/* 			ChangeDirection(); */
/* 	} */

/* 	private void ChangeDirection() { */
/* 		isFacingRight = !isFacingRight; */
/* 		Vector3 localScale = transform.localScale; */
/* 		localScale.x *= -1; */
/* 		transform.localScale = localScale; */
/* 	} */

/* 	public void Jump() { */ 
/* 		if(isGrounded) { */	
/* 			rigidbody2D.AddForce(transform.up * jumpForce); */ 
/* 			isGrounded = false; */
/* 		} */
/* 	} */

/* } */
