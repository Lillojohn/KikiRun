using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalText : MonoBehaviour {

	private GameObject goal;
	private int goalnumber;

	// Use this for initialization
	void Start () {
		goal = GameObject.Find ("Goal");
		if (goal) {
			goalnumber = goal.GetComponent<Goal> ().GetGoal();
			if (gameObject.name == "GoalText") {
				gameObject.GetComponent<Text> ().text = "/ " + goalnumber.ToString ();
			} else {
				gameObject.GetComponent<Text> ().text = goalnumber.ToString ();
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
