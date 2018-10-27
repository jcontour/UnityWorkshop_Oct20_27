using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour {

	public GameObject player;
	public GameObject canvas;

	bool inPlay;

	// Use this for initialization
	void Start () {
		inPlay = true;
	}
	
	// Update is called once per frame
	void Update () {

		// if in play check player position
		if (inPlay) {
			// if too low, END GAME , destroy player and show canvas
			if (player.transform.position.y < -17) {
				Destroy (player);
				canvas.SetActive (true);
				inPlay = false;
			}
		} else {
			// if game is over, allow restart by hitting R
			if (Input.GetKey(KeyCode.R)){
				SceneManager.LoadScene ("GameScene");
			}
		}		
	}
}
