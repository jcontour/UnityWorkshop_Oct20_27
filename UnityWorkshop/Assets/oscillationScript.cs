using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oscillationScript : MonoBehaviour {

	float move;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		move = Mathf.Sin (Time.time*10)*5;
		transform.position = new Vector3 (move, transform.position.y, transform.position.z);
	}
}
