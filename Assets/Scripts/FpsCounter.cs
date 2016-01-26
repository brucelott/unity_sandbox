using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FpsCounter : MonoBehaviour {

	[SerializeField] Text text;
	float deltaTime = 0.0f;

	void Update() {
		deltaTime += (Time.deltaTime - deltaTime) * 0.1f;
		float fps = 1f / deltaTime;
		text.text = fps.ToString("F0");
	}

}
