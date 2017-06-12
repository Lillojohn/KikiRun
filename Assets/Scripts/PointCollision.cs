using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointCollision : MonoBehaviour {
	private PointManager _pointManager;
	public void Constructor(PointManager pointManager){
		_pointManager = pointManager;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "Nick")
		{
			_pointManager.AddPoint();
			Destroy(gameObject);
		}
	}

}
