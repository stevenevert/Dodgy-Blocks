using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    public GameObject gameWin;
    // Creating an object from Player script
    Player user;

    /// <summary>
    /// Initializing the object that is to be touched to win in a level
    /// </summary>
    void Start () {
        gameWin.gameObject.SetActive(false);
        //Scene currentScene = SceneManager.GetActiveScene();
        //string currentName = currentScene.name;
        user = GameObject.Find("Player").GetComponent<Player>();
    }
	

    
    void OnCollisionEnter2D(Collision2D other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;
        if (other.transform.CompareTag("Player"))
        {
            switch (currentName)
            {
                case "Level_Eric1":
                    if (UIControl.deaths < gameControl.Lvl1Deaths)
                    {
                        gameControl.Lvl1Deaths = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.Lvl1Time)
                    {
                        gameControl.Lvl1Time = UIControl.timer;
                    }
                    if (user.coins == 3)
                    {
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                
                case "Level_Steven":
                    if (UIControl.deaths < gameControl.Lvl2Deaths)
                    {
                        gameControl.Lvl2Deaths = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.Lvl2Time)
                    {
                        gameControl.Lvl2Time = UIControl.timer;
                    }
                    if (user.coins == 0)
                    {
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Dominick":
                    if (UIControl.deaths < gameControl.Lvl3Deaths)
                    {
                        gameControl.Lvl3Deaths = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.Lvl3Time)
                    {
                        gameControl.Lvl3Time = UIControl.timer;
                    }
                    if (user.coins == 0)
                    {
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Matthew":
                    if (UIControl.deaths < gameControl.Lvl4Deaths)
                    {
                        gameControl.Lvl4Deaths = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.Lvl4Time)
                    {
                        gameControl.Lvl4Time = UIControl.timer;
                    }
                    if (user.coins == 0)
                    {
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Kian1":
                    if (UIControl.deaths < gameControl.Lvl5Deaths)
                    {
                        gameControl.Lvl5Deaths = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.Lvl5Time)
                    {
                        gameControl.Lvl5Time = UIControl.timer;
                    }
                    if (user.coins == 0)
                    {
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
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

         

            
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;
        if (other.transform.CompareTag("Player"))
        {
            switch (currentName)
            {
                case "Level_Eric2":
                    if (UIControl.deaths < gameControl.Lvl1Deaths)
                    {
                        gameControl.Lvl1Deaths = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.Lvl1Time)
                    {
                        gameControl.Lvl1Time = UIControl.timer;
                    }
                    if (user.coins == 0)
                    {
                        if (other.tag == "Goal")
                        {
                            gameWin.gameObject.SetActive(true);
                            Time.timeScale = 0;
                        }
                    }
                    break;
            }
        }
    }



}
