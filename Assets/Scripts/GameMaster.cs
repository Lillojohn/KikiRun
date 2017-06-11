using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;
	private Goal _goal;
	private int _maxScore = 10;

	void awake() {
		if(gm == null) {
			gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>(); 
		}	
	}

	void Start(){
		GameObject goal = GameObject.Find ("Goal");
		_goal = goal.GetComponent<Goal>();
		_maxScore = _goal.GetGoal();
		_goal.startGame();
	}

	public void CheckGameOver(int score) {
		if(score >= _maxScore) {
			EndGame(score);
		}
	}

	private void EndGame(int score) {
		_goal.endGame();
		Application.LoadLevel("EndScreen");
	}
}
