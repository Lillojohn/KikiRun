using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public GameObject Target;
	public GameObject Canvas;
	private string _targetUrl = "http://localhost:3000/targets";
	// Use this for initialization
	void Start () {
         WWW www = new WWW(_targetUrl);
         StartCoroutine(getTargets(www));
     }

	 public void startGame() {
		 Debug.Log("STARTING GAME");
		 SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	 }
 
     IEnumerator getTargets(WWW www)
     {
         yield return www;
 
         // check for errors
         if (www.error == null)
         {
			 RectTransform crt = (RectTransform)Canvas.transform;
			 RectTransform trt = (RectTransform)Target.transform;
			 float canvasWidth = crt.rect.width;
			 float targetWidth = trt.rect.width;

			 // Calculate the position that should be left of the targets.
			 float marginLeft = (canvasWidth - targetWidth * 3) / 4;

			 TargetList list = JsonUtility.FromJson<TargetList>(www.data);
			 int i = 1;
			 int y = 0;
			 foreach(Target target in list.targets) {
				 GameObject newTarget = Instantiate(this.Target);				 
				 newTarget.transform.parent = Canvas.transform;
				 newTarget.transform.localPosition = new Vector3((-(canvasWidth/2) + targetWidth/2) + (i * marginLeft) + (y * targetWidth), 0, 0);
				 Button b = newTarget.GetComponent<Button>();
				 b.onClick.AddListener(() => startGame());
				 i++;
				 y++;
			 }
         } else {
             Debug.Log("WWW Error: "+ www.error);
         }    
     }
}

[Serializable]
public class TargetList {
	public Target[] targets;
}

[Serializable]
public class Target {
	public int totalCoins;
}