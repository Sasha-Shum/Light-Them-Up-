using UnityEngine;
using System.Collections;

/// <summary>
/// Help screen script
/// </summary>
public class HelpScript : MonoBehaviour
{
	/// <summary>
	/// The start button skin.
	/// </summary>
	private GUISkin startBtn;
	
	void Start()
	{
		//call this during start to load the resource for the button(s) you wish to create skins for
		startBtn = Resources.Load ("StartGame_Button_Skin") as GUISkin;
	}

	void OnGUI()
	{
		//change the next gui function called
		GUI.skin = startBtn;

		const int buttonWidth = 130;
		const int buttonHeight = 130;
		
		// Determine the button's place on screen
		// Center in X, 2/3 of the height in Y
		Rect buttonRect = new Rect(
			Screen.width / 1.38f,
			Screen.height / 1.3f,
			buttonWidth,
			buttonHeight
			);
		
		// Draw a button to start the game
		if(GUI.Button(buttonRect,""))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("PlayAnimatic");
		}
	}
}