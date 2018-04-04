using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour {

	GameObject fogBackgroundImage;
	public GameSettings gameSettingsMenu;
	public GameObject pauseButton;

	void Update() {
		if (Input.GetKeyDown(KeyCode.Escape)) { // Handle Escape button for turn off pause
			ResumeGame();
		}
	}
	/// <summary>
	/// ExitGame function is called when player decided exit from main menu.
	/// </summary>
	public void ExitGame() {
		Application.Quit();
	}
	/// <summary>
	/// StartGame using for start demo level button in main menu.
	/// It is load DemoLevel scene.
	/// </summary>
	public void StartGame() {
		SceneManager.LoadScene("DemoLevel");
	}
	/// <summary>
	/// ResumeGame function is called when player pressed Resume button
	/// or Escape button in pause menu.
	/// </summary>
	public void ResumeGame() {
		if (this.fogBackgroundImage) { // check existance
			fogBackgroundImage.SetActive(false); // turn off fog
		}
		this.gameObject.SetActive(false); // turn off this pause panel
		this.pauseButton.SetActive(true); // turn on pause button in game mode
		Time.timeScale = 1;
	}
	/// <summary>
	/// Setting pause in the game mode after player clicked pause button or
	/// pressed Escape button
	/// </summary>
	/// <param name="fogBackgroundImage">Fog Background image gameOgject</param>
	/// <param name="pauseButton">Pause Button gameOgject in Game Mode</param>
	public void PauseGame(GameObject fogBackgroundImage, GameObject pauseButton) {
		if (!this.fogBackgroundImage) { // check existance
			this.fogBackgroundImage = fogBackgroundImage; // set Fog background gameOgject
		}
		if (!this.pauseButton) { // check existance
			this.pauseButton = pauseButton; // set Pause Button
		}
		this.pauseButton.SetActive(false); // Turn off pause button in game mode
		Time.timeScale = 0; // Trun of game timeScale which control motions
	}
	/// <summary>
	/// Function is called when mainmenu Credits button was pressed.
	/// </summary>
	public void Credits() {
		Debug.Log("CREDITS");
	}
	/// <summary>
	/// Save button just for visibility...
	/// </summary>
	public void Save() {
		Debug.Log("Not Implemented...");
	}
	/// <summary>
	/// MainMenu function is called when player decided go to main menu.
	/// </summary>
	public void MainMenu() {
		Time.timeScale = 1; // Turn on game timeScale (for future start after pause)
		SceneManager.LoadScene("MainMenu"); // Loading main menu scene
	}
	/// <summary>
	/// GameSettings is called when player decided click Settings button in main menu
	/// </summary>
	public void GameSettings() {
		if (gameSettingsMenu) { // check existance
			gameSettingsMenu.gameObject.SetActive(true); // turn on game settings menu
			gameSettingsMenu.SetMainMenu = this.gameObject; // set Main menu gameObject for settings
			this.gameObject.SetActive(false); // turn off this main menu
		}
	}
}
