using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour {

    public string newGameScene;
    public string howToPlay;
    public string mainMenu;
    
    void Start () {
		
	}
	
	void Update () {
		
	}
    public void NewGame()
    {
        SceneManager.LoadScene(newGameScene);
    }
    public void howTo()
    {
        SceneManager.LoadScene(howToPlay);
    }
    public void titleMenu()
    {
        SceneManager.LoadScene(mainMenu);
    }

}
