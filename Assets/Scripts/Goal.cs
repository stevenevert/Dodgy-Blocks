using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {

    public GameObject gameWin;

    // Use this for initialization
    void Start () {
        gameWin.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {


		
	}


    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.transform.CompareTag("Player"))
        {
            if (deathControl.deaths < gameControl.Lvl1Deaths)
            {
                gameControl.Lvl1Deaths = deathControl.deaths;
            }
            gameWin.gameObject.SetActive(true);
            Time.timeScale = 0;
        }
    }


}
