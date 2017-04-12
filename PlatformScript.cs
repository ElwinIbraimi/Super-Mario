using UnityEngine;
using System.Collections;

public class PlatformScript : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void OnTriggerEnter(Collider other)
	{
		transform.Translate(0, -1, 0);
	}

}
