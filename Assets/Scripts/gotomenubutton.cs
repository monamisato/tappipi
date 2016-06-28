using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class gotomenubutton : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {


	}

	public void StartButton() {
		SceneManager.LoadScene("menu");
	}
}
