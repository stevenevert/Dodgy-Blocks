using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    public GameObject gameOver;

    public static float timer;
    private bool canCount = true;
    private bool doOnce = false;


	/// <summary>
    /// Initializing the timer
    /// </summary>
	void Start () {
        timer = mainTimer;
	}
	
	/// <summary>
    /// Defining the timer so that it starts counting up with a floating type value
    /// </summary>
	void Update () {
        if( timer >= 0.0f && canCount)
        {
            timer += Time.deltaTime;
            uiText.text = timer.ToString("F"); // creating string into a float value
        }
        else if(timer <= 0.00)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.00f;
            Time.timeScale = 0;

        }
		
	}
}
