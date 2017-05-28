using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carousel : MonoBehaviour {

	private bool targetsFound = false;
	private GameObject[] list;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(!targetsFound && waitForTargets()) {
			InvokeRepeating("animate", 3f, 3f);
		}
	}

	private bool waitForTargets() {
		list = GameObject.FindGameObjectsWithTag("Target");
		if(list.Length > 0) {
			targetsFound = true;
			return true;
		}
		return false;
	}

	private void animate() {
		Debug.Log("ANIMATE");	
	}
}
