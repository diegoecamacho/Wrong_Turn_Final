using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameTimer : MonoBehaviour {

	public float gameLapse = 150.0f;
	public string levelToLoad;
	public Color loadToColor = Color.black;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		gameLapse -= Time.deltaTime;

		if (gameLapse <= 0) 
		{
			SceneManager.LoadScene ("victory");
		}

		if (flashlightScript.timerText <= 0) 
		{
			Initiate.Fade(levelToLoad,loadToColor,1f);
		}

	}

	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.tag == "enemy") 
		{
			Initiate.Fade(levelToLoad,loadToColor,1f);
			//SceneManager.LoadScene (levelToLoad);
		}
	}
}
