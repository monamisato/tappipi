using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gameclear : MonoBehaviour {

	void Start () {

	}

	void Update () {

	}

	void OnTriggerEnter(Collider other){
		Debug.Log ("here:)");

		if (other.gameObject.name == "Tapioca") {
			SceneManager.LoadScene ("goal"); 

		} 
	}
}