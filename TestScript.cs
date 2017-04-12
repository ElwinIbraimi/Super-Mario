using UnityEngine;
using System.Collections;

public class TestScript : MonoBehaviour {

public Vector3 Beginpositie;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	
	if (Input.GetAxisRaw("Horizontal") >0.1F)
	{
		transform.Translate(1,0,0) ;
	}
	
	if (Input.GetAxisRaw("Horizontal") <-0.1F)
	{
		transform.Translate(-1,0,0) ;
	}
	
	if (Input.GetAxisRaw("Vertical") >0.1F)
	{
		transform.Translate(0,1,0) ;
	}
	
	if (Input.GetAxisRaw("Vertical") <-0.1F)
	{
		transform.Translate(0,-1,0) ;
	}
	
	
	
	}
	
	void OnTriggerStay (Collider other) {
		
		if (other.gameObject.tag == "enemy")
			
			{
				transform.position = Beginpositie;
			}
		
	}
}
