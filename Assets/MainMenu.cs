using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame ()
    {
        int i = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //SceneManager.GetActiveScene().buildIndex + 1
                                  //"Level_Eric"
    }

    public void Quit()
    {
        Debug.Log("Quit's Application");
        Application.Quit();
    }
}
