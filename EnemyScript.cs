using UnityEngine;
using System.Collections;

public class EnemyScript : MonoBehaviour {
	// Variabele aanmaken
	public float snelheid;
	private Animator myAnimator;

	// Use this for initialization
	void Start () {
		// Call the animator just once at the start
		myAnimator = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
	
		// de enemy laten bewegen
		transform.Translate (snelheid * Time.deltaTime, 0, 0);



		// setting up the variables 
	


		myAnimator.SetBool ("EnemyDeath", KillEnemy.EnemyDeath);



	}
}
