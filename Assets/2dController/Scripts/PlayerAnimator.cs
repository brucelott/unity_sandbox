/* using UnityEngine; */
/* using System.Collections; */

/* public class PlayerController : MonoBehaviour { */

/* 	public float maxSpeed = 10f; */
/* 	public float jumpForce = 300f; */
/* 	private float horizontalMove = 0; */
/* 	bool isFacingRight = true; */
/* 	bool isGrounded = true; */
/* 	private float lastX; */
/* 	Animator animator; */

/* 	void OnEnable() { */
/* 		ControllerBroadcaster.Jump += Jump; */
/* 		ControllerBroadcaster.HorizontalJoyAxis += HorizontalMove; */
/* 	} */

/* 	void OnDisable() { */
/* 		ControllerBroadcaster.Jump -= Jump; */
/* 		ControllerBroadcaster.HorizontalJoyAxis -= HorizontalMove; */
/* 	} */

/* 	void Start() { */
/* 		lastX = gameObject.transform.position.x; */
/* 		animator = GetComponent<Animator>(); */
/* 	} */

/* 	void Update() { */
/* 		// Check if character is on the ground. */
/* 		if(!isGrounded && rigidbody2D.velocity.y == 0) */
/* 			isGrounded = true; */
/* 	} */

/* 	void FixedUpdate() { */
/* 		thisX = gameObject.transform.position.x; */
/* 		if(thisX > thatX && !isFacingRight) */ 
/* 			ChangeDirection(); */
/* 		else if(thisX < thatX && isFacingRight) */
/* 			ChangeDirection(); */
/* 		// Flip character direction if necessary. */
/* 		if(horizontalMove > 0 && !isFacingRight) */
/* 			ChangeDirection(); */
/* 		else if(horizontalMove < 0 && isFacingRight) */
/* 			ChangeDirection(); */
/* 	} */

/* 	public void Jump() { */ 
/* 		if(isGrounded) { */	
/* 			rigidbody2D.AddForce(transform.up * jumpForce); */ 
/* 			isGrounded = false; */
/* 			animator.SetTrigger("Jump"); */
/* 		} */
/* 	} */

/* 	public HorizontalMove(float horizontalMove) { */
/* 		// Set the velocity. */
/* 		rigidbody2D.velocity = new Vector2(horizontalMove * maxSpeed, */ 
/* 																			 rigidbody2D.velocity.y); */
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

/* } */
