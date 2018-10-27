using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

	Rigidbody rb;
	float jumpForce;
	float sideways;
	bool isJumping;
	public GameObject gamemngr;

	// Use this for initialization
	void Start () {
		jumpForce = 10;
		sideways = 5;
		rb = GetComponent<Rigidbody> ();
		isJumping = false;
		gamemngr = GameObject.FindGameObjectWithTag ("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		//only jump if you're on a platform
		if (!isJumping) {
			if (Input.GetKey(KeyCode.UpArrow)) {
				rb.AddForce (Vector3.up*jumpForce, ForceMode.Impulse);
				isJumping = true;
			}
		}

		//horizontal movement
		if (Input.GetKeyDown(KeyCode.LeftArrow)){
			rb.AddForce (Vector3.left*sideways, ForceMode.VelocityChange);
		}
		if (Input.GetKeyDown (KeyCode.RightArrow)){
			rb.AddForce (Vector3.right*sideways, ForceMode.VelocityChange);
		}

		// wrap around screen
		if (transform.position.x < -13) {
			transform.position = new Vector3 (12.5f, transform.position.y, 0);
		}
		if (transform.position.x > 13){
			transform.position = new Vector3 (-12.5f, transform.position.y, 0);
		}

		//lose when you fall off the screen
		if (transform.position.y < -11){
			gamemngr.GetComponent<GameManagement> ().Lose ();
		}
	}

	// when we hit the top of a platform
	void OnTriggerEnter(Collider other){
		isJumping = false;
	}
}
