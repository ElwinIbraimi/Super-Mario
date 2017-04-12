using UnityEngine;
using System.Collections;

public class CollectCoin : MonoBehaviour {

	public GameObject coin;
	public AudioClip geluid1;

	// Use this for initialization
	void Start () {
		//GetComponent<AudioSource> ().clip = geluid1;
		//GetComponent<AudioSource> ().Play ();
		AudioSource audio = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update () {



	}
	// if the player touches the coin
	void OnTriggerEnter(Collider Other)
	{
		AudioSource.PlayClipAtPoint(geluid1, new Vector3(5, 1, 2));
		// Destroy the coin
		Destroy (coin);
		// play a sound

		// increase the score by 1
		PlayerMovement.Score++;
	}

}
