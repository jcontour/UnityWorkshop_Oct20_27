using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePlatforms : MonoBehaviour {

	public GameObject platform;
	float timer;
	public float timerval;

	// Use this for initialization
	void Start () {
		
		timer = timerval;
		
	}
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			GameObject p = Instantiate(platform, new Vector3(Random.Range(-12, 12), 12, 0), Quaternion.identity);
			p.transform.localScale = new Vector3 (Random.Range (2, 10), 0.5f, 1);
			timer = timerval;
		}
		
	}
}
