using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpIndicator : MonoBehaviour {

	public GameObject indicationCircle;

	// Use this for initialization
	void Start () {
		indicationCircle = GameObject.Find ("IndicationCircle");
		indicationCircle.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D (Collider2D  col)
	{
		if(gameObject.name == "JumpIndicator1" && col.gameObject.name == "Nick")
		{
			indicationCircle.GetComponent<SpriteRenderer> ().color = new Color (1, 0, 0, 1);
		}

		if(gameObject.name == "JumpIndicator2" && col.gameObject.name == "Nick")
		{
			indicationCircle.GetComponent<SpriteRenderer> ().color = new Color (1, 0.9f, 0, 1);
		}

		if(gameObject.name == "JumpIndicator3" && col.gameObject.name == "Nick")
		{
			indicationCircle.GetComponent<SpriteRenderer> ().color = new Color (0, 1, 0, 1);
		}
	}  

	void OnTriggerExit2D (Collider2D  col){
		if(gameObject.name == "JumpIndicator3" && col.gameObject.name == "Nick")
		{
			indicationCircle.GetComponent<SpriteRenderer> ().color = new Color (0, 0, 0, 0);
		}
	}
}
