using UnityEngine;
using System.Collections;

public class ClockFaceRenderer : MonoBehaviour {
	public GameObject face;
	public GameObject[] tickMarks;
	private int numTickMarks = 60;
	
	void Start(){
		// clock face is off center.
		face = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
		face.transform.localRotation = Quaternion.Euler(90, 0, 0);
		face.transform.localScale = new Vector3(9f, 0.1f, 9f);
		face.transform.localPosition = new Vector3(0f, 0f, 0f);
		/*
		tickMarks = new GameObject[numTickMarks];
		float ticksToDegrees = 360f/60f;
		for (int i = 0; i < numTickMarks; i++){
			GameObject tickMark = GameObject.CreatePrimitive(PrimitiveType.Cube);
			tickMark.transform.localScale = Vector3.one;
			tickMark.transform.localPosition = new Vector3(0, 1, 0);
			tickMark.transform.localRotation = Quaternion.Euler(0f, 0f, ticksToDegrees * i);
			tickMarks[i] = tickMark;
		}*/
	}
}