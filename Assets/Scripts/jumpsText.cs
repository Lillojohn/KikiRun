using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class jumpsText : MonoBehaviour {

	private GameObject jumpGoal;


	// Use this for initialization
	void Start () {
		jumpGoal = GameObject.Find ("JumpGoal");
		if (jumpGoal) {			
			int jumpCount = jumpGoal.GetComponent<JumpGoal> ().GetJumps ();
			gameObject.GetComponent<Text> ().text = jumpCount.ToString ();
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
