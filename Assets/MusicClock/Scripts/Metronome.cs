using UnityEngine;
using System.Collections;

public class Metronome : MonoBehaviour {

	AudioSource audioSource;	

	void Awake() {
		audioSource = GetComponent<AudioSource>();
	}	

	void OnEnable() {
		ClockSource.OnTick += Click;
	}

	void OnDisable() {
		ClockSource.OnTick -= Click;
	}

	void Click(int tickNumber) {
		audioSource.Play();
	}

}
