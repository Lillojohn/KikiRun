using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private GameObject _pointManager;
	private GameObject _variablePoint;
	private int _point;
	private Text _textcomponent;

	// Use this for initialization
	void Start () {
		_pointManager = Instantiate (Resources.Load ("Prefabs/PointManager")) as GameObject;
		_pointManager.GetComponent<PointManager> ().AddScoreManager (this);
		GameObject variableText = GameObject.Find("Canvas/variablePoint");
		_textcomponent = variableText.GetComponent<Text> ();
		_point = 0;
	}
	
	void Update () {
		GameMaster.CheckGameOver(_point);
	}

	public void AddPoint(){
		_point++;

		Debug.Log(_point);

		_textcomponent.text = _point.ToString();
	}
}
