using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpManager : MonoBehaviour {

	private GameObject jumpGoal;

	// Use this for initialization
	void Start () {
		jumpGoal = GameObject.Find ("JumpGoal");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addJump(){
		jumpGoal.GetComponent<JumpGoal> ().addJump();
	}
}