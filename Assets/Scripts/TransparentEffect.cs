using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransparentEffect : MonoBehaviour {

	private bool selected;
	public Camera camera;

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<RawImage> ().color = new Color (1, 1, 1, 0.6f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D col)
	{
		if(col.gameObject.name == "SelectionArea")
		{
			gameObject.GetComponent<RawImage> ().color = new Color (1, 1, 1, 1);
		}
	} 

	void OnCollisionExit2D (Collision2D col)
	{
		if(col.gameObject.name == "SelectionArea")
		{
			gameObject.GetComponent<RawImage> ().color = new Color (1, 1, 1, 0.6f);
		}
	} 
}
