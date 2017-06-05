using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauzeManager : MonoBehaviour {

	private bool pauze;
	private GameObject _nick;
	private float resumeTimer;
	public float resumeTime;
	public GameObject _blockManager;
	public GameObject _pointManager;

	void Start(){
		pauze = false;
		_nick = GameObject.Find ("nick");
		_blockManager = GameObject.Find ("BlockManager");
		_pointManager = GameObject.Find ("PointManager");
	}

	void Update(){
		resumeTimer++;
		if (Input.GetKeyDown ("space") && pauze == true) {
			resumeTimer = 0;
		}

		if (resumeTimer == 20) {
			ResumeGame ();
		}
	}


	public void PauzeGame(){
		if (resumeTimer > resumeTime) {
			pauze = true;
			_nick.GetComponent<NickAnimations> ().SetPauze (true);
			_blockManager.GetComponent<BlockManager> ().PauzeBlocks ();
			_pointManager.GetComponent<PointManager> ().PauzePoints ();
		}
	}

	public void ResumeGame(){
		pauze = false;
		_nick.GetComponent<NickAnimations> ().SetPauze(pauze);
		_blockManager.GetComponent<BlockManager> ().ResumeBlocks ();
		_pointManager.GetComponent<PointManager> ().ResumePoints ();
	}

	public bool GetPauze(){
		return pauze;
	}
}


