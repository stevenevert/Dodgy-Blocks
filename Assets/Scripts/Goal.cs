using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


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
            //gameWin.gameObject.SetActive(true);
            Time.timeScale = 0;
            SceneManager.LoadScene(1);

        }
    }


}
