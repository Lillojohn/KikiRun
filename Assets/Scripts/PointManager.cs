using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointManager : MonoBehaviour {

	private List<GameObject> gameObjectList;
	public float triggerTime;
	public float offset;
	private float timer;
	private float randomOffset;
	private Random rnd;
	private ScoreManager _scoremanager;
	private PauzeManager _pauzemanager;


	// Use this for initialization
	void Start () {
		gameObjectList = new List<GameObject> ();
		_scoremanager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
		_pauzemanager = GameObject.Find ("PauzeManager").GetComponent<PauzeManager> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer++;

		if (timer > triggerTime + randomOffset  && _pauzemanager.GetPauze() == false) {
			CreatePoint ();
			timer = 0;
		}
	}

	public void CreatePoint(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/Point")) as GameObject); 
		gameObjectList [gameObjectList.Count - 1].GetComponent<PointCollision> ().Constructor (this);
		randomOffset = Random.Range (0, offset);
	}


	public void AddPoint(){
		_scoremanager.AddPoint ();
	}

	public void PauzePoints(){
		foreach (var point in gameObjectList) {
			if (point != null) {
				var levelmovement = point.GetComponent<LevelMovement> ();
				levelmovement.Pauze ();
			}
		}
	}

	public void ResumePoints(){
		foreach (var point in gameObjectList) {
			if (point != null) {
				var levelmovement = point.GetComponent<LevelMovement> ();
				levelmovement.Resume ();
			}
		}
	}
}
