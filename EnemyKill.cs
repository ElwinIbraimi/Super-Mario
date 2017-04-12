using UnityEngine;
using System.Collections;

public class EnemyKill : MonoBehaviour {


	public Vector3 Enemyposition;
	public Transform Goomba;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

	

	}


	// waar iets word getriggered
	void OnTriggerStay(Collider other)
	{




		// als een aangegeven object de tag enemy heeft
		if (other.gameObject.tag == ("player"))
			{
			// woord het aangegeven object weer terug gestuurd naar de startpositie
			Goomba.transform.position = Enemyposition;
		}
	}
}
