using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextGame : MonoBehaviour {

	private float _time;
	private float _startTime;

	// Use this for initialization
	void Start () {
		_startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		_time = Time.time;	

		if (_time - _startTime > 10) {
			Application.LoadLevel("Main Menu");
		}
	}
}
