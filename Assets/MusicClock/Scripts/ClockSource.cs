using UnityEngine;
using System.Collections;

public class ClockSource : MonoBehaviour {

	public delegate void ClockTick(int tick);
    public static event ClockTick OnTick;

	private int currentTick = -1;
	private float timeBetweenTicks, lastTickTime;
	private bool isPlaying = false;

	private float bpm;
	public float Bpm {
		set {
			bpm = Mathf.Clamp(value, 20f, 999f);
			UpdateTimeBetweenTicks();
		}
		get { return bpm; }
	}

	private int ticksPerBeat = 4;
	public int TicksPerBeat {
		set { ticksPerBeat = Mathf.Max(value, 0); }
		get { return ticksPerBeat; }
	}

	void Awake() {
		Bpm = 120f;
	}

	void Update() {
		if(isPlaying) {
			if(Time.time - lastTickTime >= timeBetweenTicks) {
				Tick();
			}
		}
	}

	void UpdateTimeBetweenTicks() {
		float secondsPerBeat = 60f / bpm;
		timeBetweenTicks = secondsPerBeat / ticksPerBeat;
	}

	public void Tick() {
		currentTick++;
		Debug.Log("tick: " + currentTick);
		lastTickTime = Time.time;
		if(OnTick != null) {
			OnTick(currentTick);
		}
	}

	public void Play() {
		if(isPlaying) {	
			currentTick = -1;
			Tick();
		} 
		else {
			isPlaying = true;
		}
	}

	public void Stop() {
		isPlaying = false;
	}

}
