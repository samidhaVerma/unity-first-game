﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour {

	public string mainMenu;

	public string startLevel;

	private bool isPaused;

	public GameObject pauseMenuCanvas;

	void Update()
	{
		if (isPaused) {
			pauseMenuCanvas.SetActive (true);
			Time.timeScale = 0f;
		
		} else {
			pauseMenuCanvas.SetActive (false);
			Time.timeScale = 1f;
		}

		if (Input.GetKeyDown (KeyCode.Escape)) {

			isPaused = !isPaused;
		
		}
	}

	public void Resume()
	{
		isPaused = false;

	}

	public void NewGame()
	{
		Application.LoadLevel (startLevel);
	}

	public void Quit()
	{
		Application.LoadLevel (mainMenu);
	}
}