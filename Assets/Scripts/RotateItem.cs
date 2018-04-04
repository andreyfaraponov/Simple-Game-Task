using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateItem : MonoBehaviour {

	void FixedUpdate () {
		/* Make Random rotation of item in Player hands */
		transform.Rotate(Random.rotation.eulerAngles * Time.deltaTime, Space.World);
	}
}
