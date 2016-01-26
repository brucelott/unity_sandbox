using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class BeatTrigger : MonoBehaviour {
		
	[SerializeField] int moduloValue, equalsValue;
	AudioSource audioSource;

	void Awake() {
		audioSource = GetComponent<AudioSource>();
	}

	void OnEnable() {
		ClockSource.OnTick += OnTick;
	}

	void OnDisable() {
		ClockSource.OnTick -= OnTick;
	}

	void OnTick(int tickNumber) {
		if(tickNumber % moduloValue == equalsValue) {
			audioSource.Play();
		}
	}
	
}
