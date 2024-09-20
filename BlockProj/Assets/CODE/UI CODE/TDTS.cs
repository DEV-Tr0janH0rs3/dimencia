using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TDTS : MonoBehaviour
{
	public static TDTS tdts;

	public TMP_Text errorlog;

	public TMP_InputField name;

	public static string player_name;


	public void SetUser(){
		if(name.text.Length <= 16 && name.text.Length >= 4){
			player_name = name.text;
			if(name.text.Contains(" ")){
				errorlog.text = "Your username cannot contain spaces!";
			} else {
				LoadMainMenu();
			}
		} else {
			errorlog.text = "Your username cannot be greater than 16 or below 4 characters!";
		}
	}
	private void LoadMainMenu(){
		SceneManager.LoadScene("MainMenu");
	}

}
