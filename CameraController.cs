﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

    //reference to the player
    public GameObject player;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("Player");
        offset = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
    // follow player movement
	void LateUpdate () {
        transform.position = player.transform.position + offset;
	}

}
