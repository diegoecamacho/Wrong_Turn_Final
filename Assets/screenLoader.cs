using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class screenLoader : MonoBehaviour {

	public float timer = 6f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		timer -= Time.deltaTime;

		if (timer <= 0) {
			SceneManager.LoadScene ("intro_1");
		}
			
		
	}
}
