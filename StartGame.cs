using UnityEngine;
using System.Collections;

public class StartGame : MonoBehaviour {

	public string playGameLevel;

	public void PlayGame()
	{
		// laad de aangegeven level
		Application.LoadLevel (playGameLevel);

	}



}
