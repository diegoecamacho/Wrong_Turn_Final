using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayTimer : MonoBehaviour {

	public GameObject button;

	// Use this for initialization
	void Start () {

		StartCoroutine (delay ());

		
	}
	
	// Update is called once per frame
	IEnumerator delay () {

		yield return new WaitForSeconds (5.0f);
		button.SetActive (true);
		
	}
}
