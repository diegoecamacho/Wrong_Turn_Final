﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerFollow : MonoBehaviour {

	public Transform player;
	NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent> ();
	}

	// Update is called once per frame
	void Update () {
		agent.SetDestination (player.position);
		//transform.LookAt (player);
	}
}
