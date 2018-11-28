using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform startPos;

    // Use this for initialization
    // Setting spawn point
    void Start () {
        this.transform.position = new Vector3(startPos.position.x, startPos.position.y, startPos.position.z);
    }
    
}
