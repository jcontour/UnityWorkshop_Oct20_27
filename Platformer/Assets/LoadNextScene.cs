﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNextScene : MonoBehaviour {

	public void LoadNext (string scene) {
		SceneManager.LoadScene (scene);
	}
}
