using UnityEngine;
using System.Collections;

public class KillEnemy : MonoBehaviour {

	public Transform goomba;
	public static bool EnemyDeath;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}
	// after colliding with the goomba hitbox
	void OnTriggerEnter(Collider Other)
	{

		goomba.transform.position = new Vector3 (-24.81226F, -7.82F, 0);

		EnemyDeath = true;

		if (Other.gameObject.tag == "player") 
		{
			PlayerMovement.Score++;
		}
	}

}
