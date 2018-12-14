using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {
    [SerializeField] private Text uiTextDeath;
    [SerializeField] private int mainDeaths;
    [SerializeField] private Text uiTextTime;
    [SerializeField] private float mainTimer;

    public GameObject gameOver;

    public static float timer;
    private bool canCount = true;
    private bool doOnce = false;
    public static int deaths;
    public Text deathText;

    /// <summary>
    /// 
    /// </summary>
    void Start () {
        deaths = mainDeaths;
        timer = mainTimer;
    }
	
	/// <summary>
    /// 
    /// </summary>
	void Update () {
        
        if (timer >= 0.0f && canCount)
        {
            timer += Time.deltaTime;
            uiTextTime.text = timer.ToString("F"); // creating string into a float value
        }
        else if (timer <= 0.00)
        {
            canCount = false;
            doOnce = true;
            uiTextTime.text = "0.00";
            timer = 0.00f;
            Time.timeScale = 0;

        }
    }
    /// <summary>
    /// 
    /// </summary>
    public void upDeaths()
    {
        deaths += 1;
        uiTextDeath.text = deaths.ToString();
    }
}
