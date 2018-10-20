using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {

	public float speed;

	// Use this for initialization
	void Start () {
		Debug.Log (transform.position);
//		transform.position = new Vector3 (2, 3, 1);

		speed = 1;

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = transform.position + new Vector3(0,0,speed)*Time.deltaTime;

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			speed++;
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			speed--;
		}
	}
}
