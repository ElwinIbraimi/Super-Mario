﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class NextLevelMrio1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene("Level3");
	}
}
