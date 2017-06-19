using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelector : MonoBehaviour {
	public GameObject canvas;
	public Goal goal;
	private GameObject[] _targets;
	public MainMenu MainMenu;
	private bool _found = false;
	private GameObject _goal;
	private Serial _serial;

	// Use this for initialization
	void Start () {
		StartCoroutine(checkLevels());
		_goal = GameObject.Find("Goal");
		_serial = _goal.GetComponent<Serial>();
	}
	
	// Update is called once per frame
	void Update () {
		SelectLevel ();
	}

	public void SelectLevel(){
		if(_found && (Input.GetKeyDown("space") || this._serial.GetLastLine().StartsWith("j").ToString() == "True")){
			Debug.Log("TEST");
			foreach(GameObject target in _targets) {
				RectTransform trt = (RectTransform)target.transform;
				if(target.transform.localPosition.x < trt.rect.width/2 && target.transform.localPosition.x > -(trt.rect.width/2)) {
					goal.goal = target.GetComponent<TargetBox>().value;
					goal.target = target.GetComponent<TargetBox>().target;
					chooseLevel();
				}
			}
		}
	}

	IEnumerator checkLevels() {
		yield return new WaitUntil(() => MainMenu.TargetsAquired() == true);
		_targets = GameObject.FindGameObjectsWithTag("Target");
		_found = true;
	}

	public void chooseLevel(){
		Application.LoadLevel("Prototype Game");
	}
}
