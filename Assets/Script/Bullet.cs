using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    Rigidbody rigibody;
    // Use this for initialization
    void Start () {
        rigibody = GetComponent<Rigidbody>();
        Vector3 ajustedMouvement = transform.TransformDirection(Vector3.forward);
        rigibody.AddForce(ajustedMouvement * 1000);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
