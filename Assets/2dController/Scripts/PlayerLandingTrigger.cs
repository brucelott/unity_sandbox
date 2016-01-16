using UnityEngine;
using System.Collections;

public class PlayerLandingTrigger : MonoBehaviour {
	public delegate void Trigger();
	public static event Trigger OnLanding;

	void OnCollisionEnter(Collision collision) {
		if (collision.collider.gameObject.layer == LayerMask.NameToLayer("Jumpable")){
			Debug.Log("Landed!");
			if(OnLanding != null) 
				OnLanding();
		}
	}
}
