using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour {


	//Making the variables
	public Text scoreText;
	public Text hiScoreText;

	public float scoreCount;
	public float hiScoreCount;

	public float pointsPerSecond;

	public bool scoreIncreasing; 




	// Use this for initialization
	void Start () {


		}


	// Update is called once per frame
	void Update () {
		// If the score is increasing
		if (scoreIncreasing) {

			// the Counter will show the score
			scoreCount = PlayerMovement.Score ;
		}

		// if the score count is higher than the highscore count (sorry for bad english)
		if (scoreCount > hiScoreCount) 
		{
			// the highscore counter will increase
			hiScoreCount = scoreCount;
			PlayerPrefs.SetFloat ("HighScore", hiScoreCount);
		}

		//The text will display on the screen
		scoreText.text = "Score: " + Mathf.Round (scoreCount);
		hiScoreText.text = "High Score: " + Mathf.Round (hiScoreCount);

	}
}
