using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextGame : MonoBehaviour {

	private float _time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		_time = Time.time;

		if (_time > 10) {
			Application.LoadLevel("Main Menu");
		}
	}
}
