using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseTest : MonoBehaviour {

    private bool isPaused = false;
    public GameObject PauseMenu;

    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;
            if (isPaused)
            {

                Time.timeScale = 1;
                PauseMenu.SetActive(false);
            }
            else
            {
                PauseMenu.SetActive(true);
                Time.timeScale = 0;
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
    /// <summary>
    /// Method Resuming game  and unpausing the game state
    /// Used to give functionality to a button
    /// </summary>
    public void Resume()
    {
        Time.timeScale = 1;
        PauseMenu.SetActive(false);
    }
    /// <summary>
    /// Method Moving to main menu and unpausing the game state
    /// Used to give functionality to a button
    /// </summary>
    public void MoveMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    /// <summary>
    /// Method to reset the scene and unpausing the game state
    /// Used to give functionality to a button
    /// </summary>
    public void resetLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
