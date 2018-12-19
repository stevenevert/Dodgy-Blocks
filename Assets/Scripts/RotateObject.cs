using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour {

    [SerializeField] private Vector3 axis;

	/// <summary>
    /// Rotates the transform by the axis that has an inputted value.
    /// Will be using the z axis to visually rotate the objects on the 2D plane.
    /// </summary>
	void Update () {
        transform.Rotate(axis * Time.deltaTime);
	}
}
