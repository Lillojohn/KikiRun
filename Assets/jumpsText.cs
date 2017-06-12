using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpsText : MonoBehaviour {

	private GameObject goal;


	// Use this for initialization
	void Start () {
		goal = GameObject.Find ("Goal");
		if (goal) {			
			int jumpCount = goal.GetComponent<Goal> ().GetJumps ();
			gameObject.GetComponent<Text> ().text = jumpCount.ToString ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
