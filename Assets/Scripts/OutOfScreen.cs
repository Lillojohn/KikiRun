using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutOfScreen : MonoBehaviour {

	private GameObject player ;
	private GameObject _camera;
	private float _cameraWidth;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Nick");
		_camera = GameObject.Find ("Main Camera"); 
		Camera _cam = _camera.GetComponent<Camera> ();
		_cameraWidth = _cam.rect.width/2 + 20;
	}
	
	// Update is called once per frame
	void Update () {
//		if(gameObject.transform.position.x < player.transform.localPosition.x - _cameraWidth -	 5){
//			Destroy (gameObject);
//		}
	}
}
