using UnityEngine;
using System.Collections;

public class LookAtScript : MonoBehaviour{
	public Transform target;
	
	void Update(){
		transform.LookAt(target);
	}
}