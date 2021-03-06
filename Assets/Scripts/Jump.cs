﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour {

	private float timer;
	private bool jumping;
	private Rigidbody2D rb;
	public float thrust;
	public float jumptime;
	public bool grounded;
	public Animator animator;

	// Use this for initialization
	void Start () {
		timer = 0;
		jumping = false;
		grounded = false;
		rb = gameObject.GetComponent<Rigidbody2D> ();
		animator = gameObject.GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		timer++;

		if (Input.GetKeyDown ("space") && grounded == true) {
			jumping = true;
			grounded = false;
			timer = 0;
		}


		if (timer > jumptime) {
			jumping = false;
		}

		if (jumping == true) {
			rb.AddForce(transform.up * thrust, ForceMode2D.Impulse);

		}

		animator.SetBool ("grounded", grounded);
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "Cube")
		{
			grounded = true;
		}

		if(col.gameObject.name == "Block(Clone)")
		{
			grounded = true;
		}
	}
}
