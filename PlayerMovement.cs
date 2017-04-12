using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	//hier worden alle variabelen aangemaakt
	public float snelheid;
	public bool jump;
	public Rigidbody rb;
	public bool run;
	public Vector3 Beginpositie;
	public Transform Goomba;
	public Transform Goomba1;
	public Transform Goomba2;
	public Transform Goomba3;
	public Transform flyGoomba1;
	public Transform flyGoomba2;
	public Transform flyGoomba3;
	public Transform flyGoomba4;
	public Transform flyGoomba5;
	public bool WalkRight;
	public bool WalkLeft;
	private Animator myAnimator;
	public float jumpHeight;
	public static int Score;
	public Transform Platform;
	public Vector3 platPositie;
	public Vector3 goombaPos1;
	public Vector3 goombaPos2;
	public Vector3 goombaPos3;
	public Vector3 goombaPos4;
	public Vector3 flygoombaPos1;
	public Vector3 flygoombaPos2;
	public Vector3 flygoombaPos3;
	public Vector3 flygoombaPos4;
	public Vector3 flygoombaPos5;

	// Use this for initialization
	void Start () {

		transform.position = Beginpositie;

		// Call the animator just once at the start
		myAnimator = GetComponent<Animator>();


	}
	
	// Update is called once per frame
	void Update () {
	
		// er staat dat Als er een aangegeven knop word geklikt
		if (transform.position.x + Input.GetAxis ("Horizontal") * snelheid * Time.deltaTime < 200 && transform.position.x + Input.GetAxis ("Horizontal") * snelheid * Time.deltaTime > -200)
		{
			// kan je naar links en rechts bewegen
			transform.Translate (Input.GetAxis ("Horizontal") * snelheid * Time.deltaTime, 0, 0);
		}	

		// Als je de aangegeven knop aanklikt of los laat dan wordt WalkLeft/WalkRight True of False
		if (Input.GetAxisRaw ("Horizontal") > 0.1F ) 
		{
			WalkRight = true;
		}

		if (Input.GetAxisRaw ("Horizontal") == 0 ) 
		{
			WalkRight = false;
		}


		if (Input.GetAxisRaw ("Horizontal") < -0.1F ) 
		{
			WalkLeft = true;
		}

		if (Input.GetAxisRaw ("Horizontal") == -0) 
		{
			WalkLeft = false;
		}



		// Als je de aangegeven knop Jump aanklikt en als jump/springen true/waar is
		if (Input.GetAxisRaw("Jump") !=0 && jump == true) 
		{
			//dan springt het gameObject met de Y as met een snelheid van 6
			rb.velocity = new Vector3 (0, jumpHeight, 0);
		}

		//Als je de aangegeven knop indrukt 
		if (Input.GetAxisRaw ("Fire3") != 0)
		{
			// dan word de boolean run aangevinkt
			run = true;
			// als run waar is
			if (run == true) 
			{
				// dan verandert je snelheid naar 8
				snelheid = 8;
			}
		}
		// als de aangegeven knop word losgelaten
		if (Input.GetAxisRaw ("Fire3") == 0)
		{
			// dan word de boolean niet meer aangevinkt
			run = false;

			// als de boolean niet meer is aangevinkt
			if (run == false)
			{
				//dan verandert de snelheid weer terug naar 5
				snelheid = 4;
			}

		}


		// setting up the variables 
		myAnimator.SetFloat ("snelheid", snelheid);
		myAnimator.SetBool ("WalkRight", WalkRight);
		myAnimator.SetBool ("WalkLeft", WalkLeft);
		myAnimator.SetBool ("jump", jump);


		// print the score in the console
		print ("je score = "+ Score);

	}

	// where something gets triggered
	void OnTriggerStay(Collider other)
	{
		

		// if there is an object with the tag"destroy."
		if (other.gameObject.tag == "destroy") 
		{
			// jump is waar
			jump = true;
		}

		// als een aangegeven object de tag enemy heeft
		if (other.gameObject.tag == "enemy") 
		{
			LifesMario.lifeCount-- ;
			//the player gets send back to spawn 
			transform.position = Beginpositie;
			//
			Goomba.transform.position = goombaPos1;
			Goomba1.transform.position = goombaPos2;
			Goomba2.transform.position = goombaPos3;
			Goomba3.transform.position = goombaPos4;
			flyGoomba1.transform.position = flygoombaPos1;
			flyGoomba2.transform.position = flygoombaPos2;
			flyGoomba3.transform.position = flygoombaPos3;
			flyGoomba4.transform.position = flygoombaPos4;
			flyGoomba5.transform.position = flygoombaPos5;
			Platform.transform.position = platPositie;
		}

	}
	// Where the object exits the trigger 
	void OnTriggerExit(Collider other)
	{
		// the jump boolean is false
		jump = false;
	}
}
