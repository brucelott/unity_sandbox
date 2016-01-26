using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
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

	public void Click(int tickNumber) {
		audioSource.Play();
	}

}
