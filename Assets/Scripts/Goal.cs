using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public GameObject gameWin;

    /// <summary>
    /// Initializing the object that is to be touched to win in a level
    /// </summary>
    void Start () {
        gameWin.gameObject.SetActive(false);
        //Scene currentScene = SceneManager.GetActiveScene();
        //string currentName = currentScene.name;
    }
	

    
    void OnCollisionEnter2D(Collision2D other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;
        if (other.transform.CompareTag("Player"))
        {
            switch (currentName)
            {
                case "Level_Eric":
                    if (deathControl.deaths < gameControl.Lvl1Deaths)
                    {
                        gameControl.Lvl1Deaths = deathControl.deaths;
                    }
                    if (Countdown.timer < gameControl.Lvl1Time)
                    {
                        gameControl.Lvl1Time = Countdown.timer;
                    }
                    break;
                case "Level_Steven":
                    if (deathControl.deaths < gameControl.Lvl2Deaths)
                    {
                        gameControl.Lvl2Deaths = deathControl.deaths;
                    }
                    if (Countdown.timer < gameControl.Lvl2Time)
                    {
                        gameControl.Lvl2Time = Countdown.timer;
                    }
                    break;
                case "Level_Dominick":
                    if (deathControl.deaths < gameControl.Lvl3Deaths)
                    {
                        gameControl.Lvl3Deaths = deathControl.deaths;
                    }
                    if (Countdown.timer < gameControl.Lvl3Time)
                    {
                        gameControl.Lvl3Time = Countdown.timer;
                    }
                    break;
                case "Level_Matthew":
                    if (deathControl.deaths < gameControl.Lvl4Deaths)
                    {
                        gameControl.Lvl4Deaths = deathControl.deaths;
                    }
                    if (Countdown.timer < gameControl.Lvl4Time)
                    {
                        gameControl.Lvl4Time = Countdown.timer;
                    }
                    break;
                case "Level_Kian":
                    if (deathControl.deaths < gameControl.Lvl5Deaths)
                    {
                        gameControl.Lvl5Deaths = deathControl.deaths;
                    }
                    if (Countdown.timer < gameControl.Lvl5Time)
                    {
                        gameControl.Lvl5Time = Countdown.timer;
                    }
                    break;
                default: break;
            }
           /* if (deathControl.deaths < gameControl.Lvl1Deaths)
            {
                gameControl.Lvl1Deaths = deathControl.deaths;
            }
           if (Countdown.timer < gameControl.Lvl1Time)
           {
                gameControl.Lvl1Time = Countdown.timer;
           }*/
            gameWin.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
