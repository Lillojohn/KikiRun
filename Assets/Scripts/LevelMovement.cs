using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelMovement : MonoBehaviour {


	public float speed;
	public float oldspeed;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.Translate (Vector3.left * speed);

		if (gameObject.transform.position.x < -11) {
			Destroy(gameObject);
		}
	}

	public void Pauze(){
		oldspeed = 0.05f;
		speed = 0;
	}

	public void Resume (){
		speed = oldspeed;
	}
}
