using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class loadscene : MonoBehaviour {

	// Use this for initialization
	public void changeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
