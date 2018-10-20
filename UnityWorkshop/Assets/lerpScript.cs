using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpScript : MonoBehaviour {

	Vector3 start1, end1, start2, end2;
	public float lerpVal;
	Vector3 lerp1, lerp2, comboLerp;

	// Use this for initialization
	void Start () {
		start1 = new Vector3 (-5, 0, 0);
		end1 = new Vector3 (0, 5, 0);
		start2 = new Vector3 (0, 5, 0);
		end2 = new Vector3 (5, 0, 0);
		lerpVal = 0;
	}
	
	// Update is called once per frame
	void Update () {
		lerp1 = Vector3.Lerp (start1, end1, lerpVal);
		lerp2 = Vector3.Lerp (start2, end2, lerpVal);
		comboLerp = Vector3.Lerp (lerp1, lerp2, lerpVal);
		transform.position = comboLerp;
		
	}
}
