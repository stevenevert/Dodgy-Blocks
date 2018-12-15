using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoyObject : MonoBehaviour {

	//Script to ensure that this object is not destroyed when moving to another scene
	void Awake () {
        DontDestroyOnLoad(transform.gameObject);
    //don't create another background music if there already is one
        if (FindObjectsOfType<DontDestoyObject>().Length > 1)
            Destroy(gameObject);
	}
	

}
