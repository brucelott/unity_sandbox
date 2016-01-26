using UnityEngine;
using System.Collections;

public class TempoLED : MonoBehaviour {

	private Texture texture;

	void Awake() {
		texture = GetComponent<Texture>();
	}

	// public void Blink() {
	// 	StartCoroutine(BlinkColor());
	// }

	// IEnumerator BlinkColor() {
	// 	texture.color = Color.black;
	// 	yield return new WaitForSeconds(0.01f);
	// 	texture.color = Color.white;
	// }
	
}
