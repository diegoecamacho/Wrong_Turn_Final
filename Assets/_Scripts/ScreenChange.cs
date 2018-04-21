using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScreenChange : MonoBehaviour {

	public string levelToLoad;
	public Color loadToColor = Color.black;

	public void doScreenChange(){


		Initiate.Fade(levelToLoad,loadToColor,1f);
		//SceneManager.LoadScene(levelToLoad);
	}
}
