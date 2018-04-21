using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour {

	public void doQuit()
	{
		Debug.Log ("Application Closed");
		Application.Quit();
	}
}
