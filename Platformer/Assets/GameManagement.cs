using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManagement : MonoBehaviour {

	public Text scoreText;
	public Text loseText;
	public Button restart;
	int score;
	bool isScoring;

	// Use this for initialization
	void Start () {
		score = 0;
		scoreText.text = score.ToString ();
		loseText.text = "";
		isScoring = true;
	}

	public void AddPoint(){
		if (isScoring) {
			score += 1;
			scoreText.text = score.ToString ();
		}
	}

	public void Lose(){
		isScoring = false;
		loseText.text = "GAME OVER";
		restart.gameObject.SetActive(true);
	}

}
