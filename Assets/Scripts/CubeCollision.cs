using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollision : MonoBehaviour {

	private GameObject _pauzeManager;

	// Use this for initialization
	void Start () {
		_pauzeManager = GameObject.Find("PauzeManager");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "nick")
		{
			_pauzeManager.GetComponent<PauzeManager> ().PauzeGame();
		}
	}
}
