using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTime : MonoBehaviour {

	private GameObject _goal;

	// Use this for initialization
	void Start () {
		_goal = GameObject.Find ("Goal");
		if (_goal) {
			DateTime startTime = _goal.GetComponent<Goal> ().GetStartGame ();
			DateTime endTime = _goal.GetComponent<Goal> ().GetEndGame ();
			gameObject.GetComponent<Text> ().text = (endTime - startTime).Seconds.ToString ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
