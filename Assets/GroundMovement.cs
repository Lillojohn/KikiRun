using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMovement : MonoBehaviour {
	public GameObject player; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.SetPositionAndRotation(new Vector3(player.transform.position.x, -5.95f, 0), new Quaternion(0,0,0,0));	
	}
}
