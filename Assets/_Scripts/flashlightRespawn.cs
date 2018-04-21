using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightRespawn : MonoBehaviour {

	public int count = 0;
	public GameObject self;
	public Transform[] spawner;

	// Use this for initialization
	void Start () 
	{
		//int spawnPointIndex = Random.Range(0, spawner.Length);
		//
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision other)
	{

		if (other.gameObject.tag == "light")
		{
			int spawnPointIndex = Random.Range(0, spawner.Length);
			transform.position = spawner[spawnPointIndex].position;
		}
	}
}
