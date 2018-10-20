using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionScript : MonoBehaviour {

	Rigidbody rb;
	public GameObject sphere;
	GameObject sphere2;

	void Start(){
		rb = GetComponent<Rigidbody> ();
		sphere2 = GameObject.FindGameObjectWithTag ("sphere");
	}

	void OnCollisionEnter(Collision other){
//		GetComponent<Renderer> ().material.color = Color.red;
		rb.AddForce(transform.up * 10, ForceMode.Impulse);

		sphere.transform.position = sphere.transform.position + new Vector3 (0, 1, 0);
		sphere2.transform.position = sphere2.transform.position + new Vector3 (1, 0, 0);
	}
	void OnCollisionStay(Collision other){
	
	}
	void OnCollisionExit(Collision other){
	
	}
}
