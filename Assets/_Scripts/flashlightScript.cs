using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class flashlightScript : MonoBehaviour {


	public GameObject light;
	public Text Valuetext;
	public static int timerText = 100;
	public AudioSource source;
	public AudioClip flashlight;

	void Start()
	{
		source = GetComponent<AudioSource>();
	}
	public void doLight()
	{
		timerText -= 2;
		StartCoroutine ("StartLight");
		source.PlayOneShot(flashlight,1.0f);
	}

	IEnumerator StartLight()
	{
		light.SetActive (true);
		Valuetext.text = timerText.ToString () + "%";
		yield return new WaitForSeconds (3);
		light.SetActive (false);
	}

}
