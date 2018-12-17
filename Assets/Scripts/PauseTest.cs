using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTest : MonoBehaviour {

    private bool isPaused = false;
    public GameObject PauseMenuUI; 

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {
                Time.timeScale = 1;
                PauseMenuUI.SetActive(false);
            }
            else
            {
                Time.timeScale = 0;
                PauseMenuUI.SetActive(true);
            }
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
    public void Resume()
    {
        isPaused = !isPaused;
        Time.timeScale = 1f;

    }

    public void MoveMainMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
