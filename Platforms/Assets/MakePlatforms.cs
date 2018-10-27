using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlatforms : MonoBehaviour {

	float timer;
	public float interval;

	public GameObject platform;

	// Use this for initialization
	void Start () {
		timer = 0;
	
	}
	
	// Update is called once per frame
	void Update () {

		timer += Time.deltaTime;

		if (timer >= interval) {
			// make a platform
			GameObject p = Instantiate(platform, new Vector3(Random.Range(-6,6),17,0), Quaternion.identity);
			p.transform.localScale = new Vector3 (Random.Range (2, 8), 0.5f, 1);

			// reset timer to 0
			timer = 0;
		}
		
	}
}
