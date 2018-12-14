using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    [SerializeField] private Vector3 axis;

	// Update is called once per frame
	void Update () {
        transform.Rotate(axis * Time.deltaTime);
	}
}
