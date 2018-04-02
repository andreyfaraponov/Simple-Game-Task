using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float movementSpeed;
	public float rotationSpeed;
	private float forawardBackwardMove;
	private float rotationMove;
	private Vector3 playerMovement;
	private Rigidbody playerRigidbody;
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		if (movementSpeed == 0)
			movementSpeed = 10;
		if (rotationSpeed == 0)
			rotationSpeed = 10;
		playerRigidbody = GetComponent<Rigidbody>();
	}
	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		var getRotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed * 5;
		var getMovement = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * 5;
		playerRigidbody.velocity = transform.forward * getMovement;
		transform.Rotate(0, getRotation * Time.deltaTime * rotationSpeed, 0);
	}
}
