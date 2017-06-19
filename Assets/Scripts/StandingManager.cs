using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class StandingManager : MonoBehaviour {

	private float startTime;
	private float standingTime;
	private float totalStandingTime;
	private GameObject goal;
	private bool gameStarted;
	private bool standingStill;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		standingTime = 0;
		goal = GameObject.Find ("Goal");
		gameStarted = false;
		standingStill = false;
	}
	
	// Update is called once per frame
	void Update () {
		TrackTimeStandingStill ();
	}

	public void TrackTimeStandingStill(){
		if (!gameObject.GetComponent<PlatformerCharacter2D> ().moving && gameStarted == true) {
			standingTime = Time.time - startTime;
			if (!standingStill) {
				standingStill = true;
				startTime = Time.time;
			}
		} else {
			standingStill = false;
		}
		if (standingStill == false) {
			totalStandingTime += standingTime;
			standingTime = 0;
		}
	}

	public float GetStandingTime(){
		return standingTime;
	}


	public void SetGameStarted(){
		gameStarted = true;
	}
}