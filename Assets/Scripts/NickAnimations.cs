using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NickAnimations : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void SetPauze(bool state){
		animator.SetBool ("pauze", state);
	}
}
