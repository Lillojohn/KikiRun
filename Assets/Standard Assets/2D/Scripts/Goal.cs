using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

	public int goal;
	public DateTime startTime;
	public DateTime endTime;
	public string target;
	private string _targetUrl = "http://kiki-dashboard.herokuapp.com/games";

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
		submitGame();
	}

	public void changeGoal(int x){
		goal = x;
	}

	private void submitGame() {
		WWWForm form = new WWWForm();
		form.AddField("playTime", (endTime - startTime).Seconds);
		form.AddField("coins", goal);
		WWW www = new WWW(_targetUrl, form);
		StartCoroutine(sendGame(www));
	}

	IEnumerator sendGame(WWW www) {
		yield return www;
 
         // check for errors
         if (www.error == null)
         {
			 Debug.Log("No errors!");
		 } else {
             Debug.Log("WWW Error: "+ www.error);
         } 
	}

	public int GetGoal(){
		return goal;
	}

}
