using UnityEngine;
using System.Collections;

public class PlayerSound : MonoBehaviour {
	AudioSource audioSource;
	public AudioClip jumpSound;
	public AudioClip landingSound;

	void OnEnable() {
		PlayerController.OnJump += PlayJumpSound;
		PlayerController.OnLanding += PlayLandingSound;
	}

	void OnDisable() {
		PlayerController.OnJump -= PlayJumpSound;
		PlayerController.OnLanding -= PlayLandingSound;
	}

	void Start() {
		audioSource = GetComponent<AudioSource>();
	}

	void PlayJumpSound() {
		audioSource.PlayOneShot(jumpSound);
	}

	void PlayLandingSound() {
		audioSource.PlayOneShot(landingSound);
	}
}	
