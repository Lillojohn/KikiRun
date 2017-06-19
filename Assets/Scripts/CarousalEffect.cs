using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarousalEffect : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.left * speed);
		if (gameObject.transform.position.x < - 13) {
			int targetcount = GameObject.FindGameObjectsWithTag ("Target").Length;
			if (targetcount < 5) {
				gameObject.transform.position = new Vector3 (13, 0, 0);
			} else {
				gameObject.transform.position = new Vector3 (3.9f * targetcount, 0, 0);
			}
		}
	}
}

