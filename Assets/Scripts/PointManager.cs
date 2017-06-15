using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class PointManager : MonoBehaviour {

	private List<GameObject> gameObjectList;
	public float triggerTime;
	private float randomOffset;
	private ScoreManager _scoremanager;
	public GameObject player;
	public Camera _camera;
	private float _cameraWidth;
	private float _spawnTime;
	private float _timePast;
	public float newSpawn;
	public GameObject _coinSound;

	// Use this for initialization
	void Start () {
		gameObjectList = new List<GameObject> ();
		_scoremanager = GameObject.Find ("ScoreManager").GetComponent<ScoreManager> ();
		_cameraWidth = _camera.rect.width/2 + 20;
		_spawnTime = Time.time;
		SetNewSpawn();
	}
	
	// Update is called once per frame
	void Update () {
		if(player.GetComponent<PlatformerCharacter2D>().moving) {
			if (_spawnTime + newSpawn < Time.time) {
				CreatePoint();
				_spawnTime = Time.time;
				_timePast = Time.time;
				SetNewSpawn();
			}
			_timePast = Time.time - _spawnTime;
		} else {
			_spawnTime = Time.time - _timePast;
		}
	}

	public void SetNewSpawn(){
		newSpawn = Random.Range(1f, 3f);
	}


	public void CreatePoint(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/Point")) as GameObject);
		gameObjectList [gameObjectList.Count - 1].GetComponent<PointCollision> ().Constructor (this);
		gameObjectList[gameObjectList.Count - 1].transform.SetPositionAndRotation(new Vector3(player.transform.localPosition.x + _cameraWidth, -1, 0), new Quaternion(0,0,0,0));
	}


	public void AddPoint(){
		_scoremanager.AddPoint ();
		_coinSound.GetComponent<AudioRepeat> ().PlaySound ();
	}
}
