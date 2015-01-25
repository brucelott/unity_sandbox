using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject objectToFollow;

	void FixedUpdate() {
		Vector3 tempPosition = gameObject.transform.position;
		tempPosition.x = objectToFollow.transform.position.x;
		gameObject.transform.position = tempPosition;
	}

}
