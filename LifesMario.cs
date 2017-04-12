using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LifesMario : MonoBehaviour {
	public GameObject marioLife1;
	public GameObject marioLife2;
	public GameObject marioLife3;


	public static int lifeCount;

	// Use this for initialization
	void Start () {
	
		lifeCount = 3;
		marioLife1.SetActive (true);
		marioLife2.SetActive (true);
		marioLife3.SetActive (true);

	}
	
	// Update is called once per frame
	void Update () {
	
		if (lifeCount == 3)

		{
			marioLife1.SetActive (true);
			marioLife2.SetActive (true);
			marioLife3.SetActive (true);
		}
			
		if (lifeCount == 2)

		{
			marioLife1.SetActive (true);
			marioLife2.SetActive (true);
			marioLife3.SetActive (false);
		}

		if (lifeCount == 1)

		{
			marioLife1.SetActive (true);
			marioLife2.SetActive (false);
			marioLife3.SetActive (false);
		}

		if (lifeCount == 0)

		{
			marioLife1.SetActive (false);
			marioLife2.SetActive (false);
			marioLife3.SetActive (false);
			SceneManager.LoadScene("GameDone");
		}


	}
}
