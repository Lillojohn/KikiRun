using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;
	public GameObject goal;
	private static int _maxScore = 10;
	public static int MaxScore 
	{
		get { return _maxScore; }
	}

	void awake() {
		if(gm == null) {
			gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>(); 
		}	
	}

	void Start(){
		goal = GameObject.Find ("Goal");
		_maxScore = goal.GetComponent<Goal>().GetGoal();
	}

	public static void CheckGameOver(int score) {
		if(score >= GameMaster._maxScore) {
			EndGame(score);
		}
	}

	private static void EndGame(int score) {
		Application.LoadLevel("EndScreen");
	}
}
