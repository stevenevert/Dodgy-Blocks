using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestoyObject : MonoBehaviour {

	//Script to ensure that this object is not destroyed when moving to another scene
	void Awake () {
        DontDestroyOnLoad(transform.gameObject);
	}
	

}
