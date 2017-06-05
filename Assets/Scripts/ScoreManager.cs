using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {

	private GameObject _pointManager;
	private GameObject _variablePoint;
	private int _point;

	// Use this for initialization
	void Start () {
		_point = 0;
	}
	
	void Update () {
		
	}

	public void AddPoint(){
		_point++;
		GameObject _variableText = GameObject.Find("Canvas/variablePoint");
		Text _textcomponent = _variableText.GetComponent<Text> ();
		_textcomponent.text = _point.ToString();
		GameMaster.CheckGameOver(_point);
	}
}
