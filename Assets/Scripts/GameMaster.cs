using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

	public static GameMaster gm;
	private static int _maxScore =2;
	public static int MaxScore 
	{
		get { return _maxScore; }
	}

	void awake() {
		if(gm == null) {
			gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>(); 
		}	
	}

	public static void CheckGameOver(int score) {
		if(score >= GameMaster._maxScore) {
			EndGame(score);
		}
	}

	private static void EndGame(int score) {
		Debug.Log("GAME OVER!");
	}
}
