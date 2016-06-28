using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class TapiocaLimit : MonoBehaviour {

	float x = 0.0f;

	void Update ()
	{
		x = transform.position.x;	

		if (x < -4) {
			SceneManager.LoadScene ("gameover");

		} else if (x > 3.5) {
			SceneManager.LoadScene ("gameover");
			
		}
	}
}