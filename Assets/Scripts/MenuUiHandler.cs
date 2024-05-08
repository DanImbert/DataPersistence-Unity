using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class MenuUiHandler : MonoBehaviour
{
	public InputField nameInputField;







	public void StartNew()
	{

		// Get the player's name from the input field
		string playerName = nameInputField.text;

		// Store the player's name in PlayerPrefs to pass it to the MainManager
		PlayerPrefs.SetString("PlayerName", playerName);

		// Get the current best score from PlayerPrefs
		int bestScore = PlayerPrefs.GetInt("BestScore", 0);

		// Update the best score text in PlayerPrefs with the new input score
		PlayerPrefs.SetInt("BestScore", bestScore);

		SceneManager.LoadScene(1);
		
		

	}

	public void ExitButtonClicked()
	{

		

     #if UNITY_EDITOR
		EditorApplication.ExitPlaymode();
     #else
        Application.Quit(); // original code to quit Unity player
     #endif


	}

	
	
}
