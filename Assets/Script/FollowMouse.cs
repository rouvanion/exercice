﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour {
    [SerializeField] GameObject gun;
    [SerializeField] Camera playerCamera;
    [SerializeField] GameObject player;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse X") != 0)
        {
            player.transform.Rotate(0, Input.GetAxis("Mouse X") * 20, 0);
        }
	}
}
