using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour {

	private GameObject mainMenu;

	/// <summary>
	/// Property field for setting main menu from outside.
	/// </summary>
	public GameObject SetMainMenu {
		set {
			if (!mainMenu)
				mainMenu = value;
		}
	}
	/// <summary>
	/// Back to main menu button implementation
	/// </summary>
	public void BackToMainMenu() {
		if (mainMenu) { // check for existing
			mainMenu.SetActive(true); // Turn on main menu panel
			gameObject.SetActive(false); // Turn off this panel
		}
	}
}
