using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameoverzone : MonoBehaviour {

	public int currentScene;

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){

		if (other.gameObject.name == "Tapioca") {
			PlayerPrefs.SetInt("lastScene", currentScene);
			SceneManager.LoadScene ("gameover");  

		}
	}
}