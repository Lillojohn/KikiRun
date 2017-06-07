using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockManager : MonoBehaviour {

	private List<GameObject> gameObjectList;
	private float timer; 
	public float triggerTime;
	public float offset;
	private float randomOffset;
	private Random rnd;
	private GameObject _pauzeManager;

	// Use this for initialization
	void Start () {
		gameObjectList = new List<GameObject> ();
		_pauzeManager = GameObject.Find("PauzeManager");
	}
	
	// Update is called once per frame
	void Update () {
		timer++;

		if (timer > triggerTime + randomOffset && _pauzeManager.GetComponent<PauzeManager>().GetPauze() == false) {
			int random = Random.Range (0, 4);
			if (random == 0) {
				CreateBlock ();
			}

			if (random == 1) {
				CreateTwoBlocks ();
			}

			if (random == 2) {
				CreateBlock ();
			}

			if (random == 3) {
				CreateThreeBlocks ();
			}

			timer = 0;
		}
	}

	public void CreateBlock(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/BlockA")) as GameObject); 
		randomOffset = Random.Range (0, offset);
	}

	public void CreateTwoBlocks(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/BlockA")) as GameObject); 
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/BlockA")) as GameObject);
	}

	public void CreateThreeBlocks(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/BlockA")) as GameObject); 
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/BlockA")) as GameObject); 
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/BlockA")) as GameObject); 
		float x = gameObjectList [gameObjectList.Count - 2].transform.position.x;
		float y = gameObjectList [gameObjectList.Count - 2].transform.position.y;
		gameObjectList [gameObjectList.Count - 1].transform.position = new Vector3 (x + 0.9f, y + 1.5f, 0);
	}

	public void PauzeBlocks(){
		foreach (var block in gameObjectList) {
			if (block != null) {
				var levelmovement = block.GetComponent<LevelMovement> ();
				levelmovement.Pauze ();
			}
		}
	}

	public void ResumeBlocks(){
		foreach ( var block in gameObjectList){
			if (block != null) {
				var levelmovement = block.GetComponent<LevelMovement> ();
				levelmovement.Resume ();
			}
		}
	}
}
	