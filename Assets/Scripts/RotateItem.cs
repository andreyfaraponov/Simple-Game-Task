using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour {

	void FixedUpdate () {
		transform.Rotate(Random.rotation.eulerAngles * Time.deltaTime, Space.World);
	}
}
