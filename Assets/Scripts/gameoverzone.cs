﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameoverzone : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("here:)");

		if (other.gameObject.name == "Tapioca") {
			SceneManager.LoadScene ("gameover"); 
		}
	}
}