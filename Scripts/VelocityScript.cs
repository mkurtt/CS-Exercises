using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityScript : MonoBehaviour {

    public float StartSpeed = 20f;

	// Use this for initialization
	void Start () {

        Rigidbody rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(StartSpeed, 0, StartSpeed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
