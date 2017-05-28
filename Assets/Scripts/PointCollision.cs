using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollision : MonoBehaviour {

	private PointManager _pointManager;

	public void Constructor(PointManager pointmanager){
		_pointManager = pointmanager;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "nick")
		{
			Destroy(gameObject);
			_pointManager.AddPoint ();
		}
	}

}
