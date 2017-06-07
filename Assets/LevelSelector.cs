using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelSelector : MonoBehaviour {

	private int levelchoice;
	private GameObject level0;
	private GameObject level1;
	private GameObject level2;
	private GameObject goal;

	// Use this for initialization
	void Start () {
		levelchoice = 0;
		level0 = GameObject.Find ("Level0");
		level1 = GameObject.Find ("Level1");
		level2 = GameObject.Find ("Level2");
		goal = GameObject.Find ("Goal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")){
			chooseLevel ();
		}

		if (level0.transform.position.x < 4 && levelchoice == 2) {
			levelchoice = 0;
			goal.GetComponent <Goal> ().changeGoal (10);
		}

		if (level1.transform.position.x < 4 && levelchoice == 0) {
			levelchoice = 1;
			goal.GetComponent <Goal> ().changeGoal (25);
		}

		if (level2.transform.position.x < 4 && levelchoice == 1) {
			levelchoice = 2;
			goal.GetComponent <Goal> ().changeGoal (50);
		}
	}

	public void chooseLevel(){
		Application.LoadLevel("nick");
	}
}
