using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float movementSpeed = 10f;
	public float rotationSpeed = 10f;
	private Rigidbody playerRigidbody;
	public GameObject pausePanel;
	public GameObject fogBackgroundImage;
	public MenuScript menu;
	public GameObject pauseButton;
	
	/// <summary>
	/// Start is called on the frame when a script is enabled just before
	/// any of the Update methods is called the first time.
	/// </summary>
	void Start()
	{
		pausePanel.SetActive(false); // Turn off pause panel
		fogBackgroundImage.SetActive(false); // Turn off background fog in pause menu
		playerRigidbody = GetComponent<Rigidbody>(); // Getting rigidbody component
	}
	/// <summary>
	/// Update is called every frame, if the MonoBehaviour is enabled.
	/// </summary>
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape)) { // Handle escape for game pause
			SetPause(pauseButton);
		}
	}
	/// <summary>
	/// This function is called every fixed framerate frame, if the MonoBehaviour is enabled.
	/// </summary>
	void FixedUpdate()
	{
		var getRotation = Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed * 5; // Get Horizontal axis for left/right rotation
		var getMovement = Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed * 5; // Get Vertical axis for forward and back moving 
		playerRigidbody.velocity = transform.forward * getMovement; // Setting speed and direction for player rigidbody
		transform.Rotate(0, getRotation * Time.deltaTime * rotationSpeed, 0); // Setting rotation
	}
	/// <summary>
	/// This function is called when player use Escape button or button from UI.
	/// </summary>
	/// <param name="pauseButton">Reference for pause button object</param>
	public void SetPause(GameObject pauseButton) {
		pausePanel.SetActive(true); // Turn on pause panel
		fogBackgroundImage.SetActive(true); // Turn on fog background
		menu.PauseGame(fogBackgroundImage, pauseButton); // Use ManuScript method to set pause
	}
}
