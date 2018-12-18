using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    /// <summary>
    /// Creating objects and vars to be able to hold the timer and death values to access the UI through Unity
    /// </summary>
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
    /// Initializing the timer and the death count
    /// Allowing the starting variable to be accessed through Unity
    /// </summary>
    void Start () {
        deaths = mainDeaths;
        timer = mainTimer;
    }

    /// <summary>
    /// Defining the timer so that it starts counting up with a floating type value
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
    /// Adding the amount of deaths and displaying such
    /// </summary>
    public void upDeaths()
    {
        deaths += 1;
        uiTextDeath.text = deaths.ToString();
    }
}
