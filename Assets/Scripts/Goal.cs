using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public int goal;
	public DateTime startTime;
	public DateTime endTime;
	public string target;

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		goal = 10;
	}

	public void startGame() {
		startTime = DateTime.Now;
	}

	public void endGame() {
		endTime = DateTime.Now;
	}

	public void changeGoal(int x){
		goal = x;
	}

	public int GetGoal(){
		return goal;
	}
}
