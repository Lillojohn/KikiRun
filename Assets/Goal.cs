using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public int goal;

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		goal = 10;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void changeGoal(int x){
		goal = x;
	}

	public int GetGoal(){
		return goal;
	}
}
