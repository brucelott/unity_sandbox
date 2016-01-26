using UnityEngine;
using System.Collections;

public class ClockSource : MonoBehaviour {

	private float bpm;
	public float Bpm {
		set {
			bpm = Mathf.Max(value, 1);
			UpdateTimeBetweenTicks();
		}
		get { return bpm; }
	}

	private int ticksPerBeat = 4;
	public int TicksPerBeat {
		set { ticksPerBeat = Mathf.Max(value, 0); }
		get { return ticksPerBeat; }
	}

	public delegate void ClockTick(int tick);
    public static event ClockTick OnTick;

	private int currentTick = -1;
	private bool isPlaying = false;
	private double lastTickTime, timeBetweenTicks;

	void Awake() {
		Bpm = 120f;
	}

	void FixedUpdate() {
		if(isPlaying) {
			if(AudioSettings.dspTime - lastTickTime >= timeBetweenTicks) {
				Tick();
			}
		}
	}

	public void Play() {
		if(isPlaying) {	
			Debug.Log("Clock - Restarting");
			currentTick = -1;
		} 
		else {
			Debug.Log("Clock - Starting");
			isPlaying = true;
		}
		Tick();
	}

	public void Stop() {
		Debug.Log("Clock - Stopping");
		isPlaying = false;
	}

	void Tick() {
		currentTick++;
		if(OnTick != null) {
			OnTick(currentTick);
		}
		lastTickTime = AudioSettings.dspTime;
		// Debug.Log("tick: " + currentTick);
	}

	void UpdateTimeBetweenTicks() {
		double secondsPerBeat = 60f / bpm;
		timeBetweenTicks = secondsPerBeat / ticksPerBeat;
	}

}
