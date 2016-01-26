using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SoundPlayer : MonoBehaviour {
	
	public AudioClip[] audioClips;

	private Dictionary<string, AudioClip> audioClipDict;
	private AudioSource audioSource;

	private float volume = 0.7f;
	public float Volume {
		set { volume = Mathf.Clamp(value, 0f, 1.0f); }
		get { return volume; }
	}

	void Awake() {
		audioSource = GetComponent<AudioSource>();
	}

	void Start() {
		audioClipDict = new Dictionary<string, AudioClip>();
		foreach(AudioClip audioClip in audioClips) {
			audioClipDict.Add(audioClip.name, audioClip);
		}
	}

	public void PlaySound(string soundName) {
		if(audioClipDict.ContainsKey(soundName)) {
			Debug.Log("Playing sound:" + soundName);
			audioSource.PlayOneShot(audioClipDict[soundName], volume);
		}
		else {
			Debug.Log("Cound not find sound: " + soundName);
		}
	}

}
