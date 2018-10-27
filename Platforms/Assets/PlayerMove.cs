using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	Rigidbody rb;
	public float jumpForce;
	public float sidewaysForce;

	bool canJump;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody> ();
		jumpForce = 10f;
		sidewaysForce = 3f;
		canJump = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (canJump) {
			if (Input.GetKeyDown (KeyCode.UpArrow)) {
				rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
				canJump = false;
			}
		}

		if (Input.GetKeyDown (KeyCode.LeftArrow)) {
			rb.AddForce (Vector3.left * sidewaysForce, ForceMode.VelocityChange);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)) {
			rb.AddForce (Vector3.right * sidewaysForce, ForceMode.VelocityChange);
		}

	}

	void OnTriggerEnter(Collider other){
		canJump = true;
	}
}
