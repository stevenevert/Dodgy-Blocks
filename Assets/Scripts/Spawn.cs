using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform startPos;

  
    /// <summary>
    /// Setting the spawn point at the start of the game and after a death by pulling coordinates from Unity
    /// </summary>
    void Start () {
        this.transform.position = new Vector3(startPos.position.x, startPos.position.y, startPos.position.z);
    }
    
}
