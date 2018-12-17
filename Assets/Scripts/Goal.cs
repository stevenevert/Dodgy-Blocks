using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour {

    // Creating object to activate label in Unity
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
                case "Level_Steven1":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[1])
                        {
                            gameControl.deaths[1] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[1])
                        {
                            gameControl.bestTime[1] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;

                case "Level_Dominick":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[2])
                        {
                            gameControl.deaths[2] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[2])
                        {
                            gameControl.bestTime[2] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Eric1":
                    if (user.coins == 3)
                    {
                        if (UIControl.deaths < gameControl.deaths[3])
                        {
                            gameControl.deaths[3] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[3])
                        {
                            gameControl.bestTime[3] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Kian1":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[4])
                        {
                            gameControl.deaths[4] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[4])
                        {
                            gameControl.bestTime[4] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Matthew":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[5])
                        {
                            gameControl.deaths[5] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[5])
                        {
                            gameControl.bestTime[5] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Kian2":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[6])
                        {
                            gameControl.deaths[6] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[6])
                        {
                            gameControl.bestTime[6] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Kian3":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[7])
                        {
                            gameControl.deaths[7] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[7])
                        {
                            gameControl.bestTime[7] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Kian4":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[8])
                        {
                            gameControl.deaths[8] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[8])
                        {
                            gameControl.bestTime[8] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                case "Level_Steven2":
                    if (user.coins == 0)
                    {
                        if (UIControl.deaths < gameControl.deaths[10])
                        {
                            gameControl.deaths[10] = UIControl.deaths;
                        }
                        if (UIControl.timer < gameControl.bestTime[10])
                        {
                            gameControl.bestTime[10] = UIControl.timer;
                        }
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                /* case "Level_Eric2":
                     if (user.coins == 24)
                     {
                         if (UIControl.deaths < gameControl.deaths[9])
                         {
                             gameControl.deaths[9] = UIControl.deaths;
                         }
                         if (UIControl.timer < gameControl.bestTime[9])
                         {
                             gameControl.bestTime[9] = UIControl.timer;
                         }
                         gameWin.gameObject.SetActive(true);
                         Time.timeScale = 0;
                     }
                     break;*/
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

    /// <summary>
    /// Method supporting levels in which the goal is at the same location where the spawn
    /// point is at.
    /// </summary>
    /// <param name="other"></param>
    void OnTriggerEnter2D(Collider2D other)
    {
        Scene currentScene = SceneManager.GetActiveScene();
        string currentName = currentScene.name;
        if (other.transform.CompareTag("Player"))
        {
            switch (currentName)
            {
                case "Level_Eric2":
                    if (UIControl.deaths < gameControl.deaths[9])
                    {
                        gameControl.deaths[9] = UIControl.deaths;
                    }
                    if (UIControl.timer < gameControl.bestTime[9])
                    {
                        gameControl.bestTime[9] = UIControl.timer;
                    }
                    if (user.coins == 24)
                    {
                        gameWin.gameObject.SetActive(true);
                        Time.timeScale = 0;
                    }
                    break;
                default: break;
            }
        }
    }



}
