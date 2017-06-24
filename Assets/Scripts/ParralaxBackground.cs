using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class ParralaxBackground : MonoBehaviour {

	public float speed;
	public GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (player.GetComponent<PlatformerCharacter2D> ().moving) {
			gameObject.transform.Translate (Vector3.left * speed);
		}

		if (gameObject.transform.localPosition.x < - 20) {
			gameObject.transform.Translate (new Vector3 (43, 0, 0));

		}
	}
}
