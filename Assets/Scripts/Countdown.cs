using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Countdown : MonoBehaviour {

    [SerializeField] private Text uiText;
    [SerializeField] private float mainTimer;
    public GameObject gameOver;

    private float timer;
    private bool canCount = true;
    private bool doOnce = false;


	// Use this for initialization
	void Start () {
        timer = mainTimer;
		
	}
	
	// Update is called once per frame
	void Update () {
        if( timer >= 0.0f && canCount)
        {
            timer -= Time.deltaTime;
            uiText.text = timer.ToString("F"); // creating string into a float value
        }
        else if(timer <= 0.00)
        {
            canCount = false;
            doOnce = true;
            uiText.text = "0.00";
            timer = 0.00f;
            gameOver.gameObject.SetActive(true);
            Time.timeScale = 0;

        }
		
	}
}
