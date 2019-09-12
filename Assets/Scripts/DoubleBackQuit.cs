using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleBackQuit : MonoBehaviour {

	public bool isQuiting = false;
	public GameObject quitMessageGameObject;

	// Use this for initialization
	void Start () {
		quitMessageGameObject.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if(isQuiting == true){
			if(Input.GetKeyDown(KeyCode.Escape)){
				
				Application.Quit ();
			}
		}
		if(Input.GetKeyDown(KeyCode.Escape)){
			
			quitMessageGameObject.SetActive (true);
			isQuiting = true;
			StartCoroutine (QuitingTimer ());
		}
	}

	IEnumerator QuitingTimer(){
		yield return new WaitForSeconds (3);
        isQuiting = false;
		quitMessageGameObject.SetActive (false);
	}
}