using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private GameObject pointManager;
	private GameObject variablePoint;
	private int point;
	private Text textcomponent;

	// Use this for initialization
	void Start () {
		pointManager = Instantiate (Resources.Load ("Prefabs/PointManager")) as GameObject;
		pointManager.GetComponent<PointManager> ().AddScoreManager (this);
		GameObject variableText = GameObject.Find("Canvas/variablePoint");
		textcomponent = variableText.GetComponent<Text> ();
		point = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddPoint(){
		point++;
		textcomponent.text = point.ToString();
	}
}
