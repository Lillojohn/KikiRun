using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;

	// Use this for initialization
	void Start () {
		audio = GetComponent<AudioSource>();
		audio.PlayOneShot(impact, 0.7F);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
