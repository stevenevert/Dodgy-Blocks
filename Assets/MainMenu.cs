using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    /// <summary>
    /// Functionallity of the play button is to move to the first scene
    /// </summary>
	public void PlayGame ()
    {
        int i = 1;
        SceneManager.LoadScene(1); //SceneManager.GetActiveScene().buildIndex + 1
                                  //"Level_Eric"
    }
    /// <summary>
    /// Quit Button functionality to quit the application 
    /// </summary>
    public void Quit()
    {
        Debug.Log("Quit's Application");
        Application.Quit();
    }
    /// <summary>
    /// Method for level select to move to level 1
    /// </summary>
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    /// <summary>
    /// Method for level select to move to level 2
    /// </summary>
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }
    /// <summary>
    /// Method for level select to move to level 3
    /// </summary>
    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
    /// <summary>
    /// Method for level select to move to level 4
    /// </summary>
    public void Level4()
    {
        SceneManager.LoadScene(4);
    }
    /// <summary>
    /// Method for level select to move to level 5
    /// </summary>
    public void Level5()
    {
        SceneManager.LoadScene(5);
    }
    /// <summary>
    /// Method for level select to move to level 6
    /// </summary>
    public void Level6()
    {
        SceneManager.LoadScene(6);
    }
    /// <summary>
    /// Method for level select to move to level 7
    /// </summary>
    public void Level7()
    {
        SceneManager.LoadScene(7);
    }
    /// <summary>
    /// Method for level select to move to level 8
    /// </summary>
    public void Level8()
    {
        SceneManager.LoadScene(8);
    }
    /// <summary>
    /// Method for level select to move to level 9
    /// </summary>
    public void Level9()
    {
        SceneManager.LoadScene(9);
    }
    /// <summary>
    /// Method for level select to move to level 10
    /// </summary>
    public void Level10()
    {
        SceneManager.LoadScene(10);
    }
}
