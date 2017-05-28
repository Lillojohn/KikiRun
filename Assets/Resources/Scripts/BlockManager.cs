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

	// Use this for initialization
	void Start () {
		gameObjectList = new List<GameObject> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer++;

		if (timer > triggerTime + randomOffset) {
			CreateBlock ();
			timer = 0;
		}
	}

	public void CreateBlock(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/Block")) as GameObject); 
		randomOffset = Random.Range (0, offset);
	}

	public void CreateTwoBlocks(){
		gameObjectList.Add(Instantiate(Resources.Load("Prefabs/Block")) as GameObject); 
		randomOffset = Random.Range (0, offset);
	}
}
