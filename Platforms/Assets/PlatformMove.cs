using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour {

	public float speed;

	// Update is called once per frame
	void Update () {

		transform.Translate (Vector3.down * Time.deltaTime * speed);

		if (transform.position.y < -17) {
			Destroy (this.gameObject);
		}

	}
}
