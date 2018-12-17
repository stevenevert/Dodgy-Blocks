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
        else if (Input.GetKeyDown(KeyCode.F1)){

            if (Time.timeScale > 0)
                Time.timeScale -= 0.1f;
            else
                Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.F2))
        {

            if (Time.timeScale < 2)
                Time.timeScale += 0.1f;
            else
                Time.timeScale = 1;
        }
        else if (Input.GetKeyDown(KeyCode.F3))
        {
                Time.timeScale = 1;
        }

    }
}
