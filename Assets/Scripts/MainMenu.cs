using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour {

    public string Level1;
    public string Level2;
    public string Level3;
    public string Level4;
    public string Level5;
    public string Level6;
  
    public string firstMenu;
    

    public void level1()
    {
        SceneManager.LoadScene(Level1);
    }
    public void level2()
    {
        SceneManager.LoadScene(Level2);
    }
    public void level3()
    {
        SceneManager.LoadScene(Level3);
    }
    public void level4()
    {
        SceneManager.LoadScene(Level4);
    }
    public void level5()
    {
        SceneManager.LoadScene(Level5);
    }
    public void level6()
    {
        SceneManager.LoadScene(Level6);
    }

    public void titleMenu()
    {
        SceneManager.LoadScene(firstMenu);
    }

}
