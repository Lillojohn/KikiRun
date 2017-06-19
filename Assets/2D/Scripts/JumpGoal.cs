
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpGoal : MonoBehaviour {

	public int jumps;

	void Awake () {
		DontDestroyOnLoad (transform.gameObject);
	}

	// Use this for initialization
	void Start () {
		jumps = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void addJump(){
		jumps++;
	}

	public int GetJumps(){
		return jumps;
	}
}