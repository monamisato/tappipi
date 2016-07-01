using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class retrybutton : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RetryButton() {
		int number = PlayerPrefs.GetInt("lastScene");
		if (number == 5) {
			SceneManager.LoadScene ("stage5");
		}else if(number ==1) {
			SceneManager.LoadScene ("stage1");
		} else if (number == 2) {
			SceneManager.LoadScene ("stage2");
		} else if (number == 3) {
			SceneManager.LoadScene ("stage3");
		} else if (number == 4) {
			SceneManager.LoadScene ("stage4");
		} else if (number == 6) {
			SceneManager.LoadScene ("stage6");
		
		}
	}
}
