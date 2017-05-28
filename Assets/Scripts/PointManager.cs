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


	// Use this for initialization
	void Start () {
		gameObjectList = new List<GameObject> ();
		CreatePoint ();
	}
	
	// Update is called once per frame
	void Update () {
		timer++;

		if (timer > triggerTime + randomOffset) {
			CreatePoint ();
			timer = 0;
		}
	}

	public void CreatePoint(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/Point")) as GameObject); 
		gameObjectList [gameObjectList.Count - 1].GetComponent<PointCollision> ().Constructor (this);
		randomOffset = Random.Range (0, offset);
	}

	public void AddScoreManager(ScoreManager scoremanager) {
		_scoremanager = scoremanager;
	}

	public void AddPoint(){
		_scoremanager.AddPoint();
	}
}
