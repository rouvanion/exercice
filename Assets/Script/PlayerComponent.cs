﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerComponent : MonoBehaviour {
    CharacterController CharacterController;
    // Use this for initialization
    void Start () {
        CharacterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");
        Vector3 mouvement = new Vector3(horizontal,0,vertical);
        CharacterController.SimpleMove(mouvement * Time.deltaTime*500);
	}
}
