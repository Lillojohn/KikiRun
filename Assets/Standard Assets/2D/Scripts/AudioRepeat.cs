using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioRepeat : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;

	// Use this for initialization
	void Start () {

	}

	void Update(){

	}

	public void PlaySound(){
		audio = GetComponent<AudioSource>();
		audio.PlayOneShot(impact, 0.7F);
	}
}
