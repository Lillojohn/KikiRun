using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets._2D;

public class BlockManager : MonoBehaviour {

	private List<GameObject> gameObjectList;
	public float triggerTime;
	private float randomOffset;
	public GameObject player;
	public Camera _camera;
	private float _cameraWidth;
	private float _spawnTime;
	private float _timePast;

	public float newSpawn;

	// Use this for initialization
	void Start () {
		gameObjectList = new List<GameObject> ();
		_cameraWidth = _camera.rect.width/2 + 20;
		_spawnTime = Time.time;
		SetNewSpawn();
	}
	
	// Update is called once per frame
	void Update () {
		// Debug.Log(Time.time + " - " + _spawnTime + " - " + _timePast);
		PlayerMove();
	}

	public void PlayerMove(){
		if(player.GetComponent<PlatformerCharacter2D>().moving) {
			if (_spawnTime + newSpawn < Time.time) {
				RandomBlockCreator();
				_spawnTime = Time.time;
				_timePast = Time.time;
				SetNewSpawn();
			}
			_timePast = Time.time - _spawnTime;
		} else {
			_spawnTime = Time.time - _timePast;
		}
	}

	public bool CheckPlayerMovement(){
		return player.GetComponent<PlatformerCharacter2D>().moving;
	}



	public void RandomBlockCreator(){
		int randomBlock = Random.Range(1, 4);
		switch(randomBlock) {
			case 1:
				CreateBlock();
				break;
			case 2:
				CreateTwoBlock();
				break;
			case 3:
				CreateThreeBlock();
				break;
		}
	}

	public void SetNewSpawn(){
		newSpawn = Random.Range(1f, 3f);
	}

	public void CreateBlock(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/Cube")) as GameObject);
		gameObjectList[gameObjectList.Count - 1].transform.SetPositionAndRotation(new Vector3(player.transform.localPosition.x + _cameraWidth, -3.157f, 0), new Quaternion(0,0,0,0));
	}

	public void CreateTwoBlock() {
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/TwoBlock")) as GameObject);
		gameObjectList[gameObjectList.Count - 1].transform.SetPositionAndRotation(new Vector3(player.transform.localPosition.x + _cameraWidth, -2.844432f, 0), new Quaternion(0,0,0,0));
	}

	public void CreateThreeBlock() {
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/ThreeBlock")) as GameObject);
		gameObjectList[gameObjectList.Count - 1].transform.SetPositionAndRotation(new Vector3(player.transform.localPosition.x + _cameraWidth, -2.5964f, 0), new Quaternion(0,0,0,0));
	}
}
	