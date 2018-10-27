using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

	public float speed = 2f;
	public GameObject gamemngr;

	// Use this for initialization
	void Start () {
		gamemngr = GameObject.FindGameObjectWithTag ("GameController");
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.down * Time.deltaTime * speed);

		if (transform.position.y < -12) {
			gamemngr.GetComponent<GameManagement> ().AddPoint ();
			Destroy (this.gameObject);
		}
	}


}
