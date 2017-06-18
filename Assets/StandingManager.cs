using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class StandingManager : MonoBehaviour {

	private float standingTime;
	private GameObject goal;

	// Use this for initialization
	void Start () {
		standingTime = 0;
		goal = GameObject.Find ("Goal");
	}
	
	// Update is called once per frame
	void Update () {
		if (!gameObject.GetComponent<PlatformerCharacter2D> ().moving) {
			standingTime = Time.time;
		}
	}

	public float GetStandingTime(){
		return standingTime;
	}


}
