using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseTest : MonoBehaviour {

    private bool isPaused = false;

	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
                Time.timeScale = 1;
            else
                Time.timeScale = 0;
        }
	}
}
