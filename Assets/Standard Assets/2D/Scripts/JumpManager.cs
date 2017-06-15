using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpManager : MonoBehaviour {

	private GameObject goal;

	// Use this for initialization
	void Awake () {
		goal = GameObject.Find ("Goal");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addJump(){
//		goal.GetComponent<Goal> ().addJump ();
//		Debug.Log("nice");
	}
}
