using UnityEngine;
using System.Collections;

public class tapiocafall : MonoBehaviour {
	//Array 
	public GameObject[] tapiocas;

	public float timer = 0;
	public float limit = 0;

	// Use this for initialization
	void Start () {
	
		//タグがついているものをまとめて取得
		tapiocas = GameObject.FindGameObjectsWithTag ("tapioca");
		limit = 5 + Random.Range (1.0f, 2.0f);

		for (int i = 0; i < tapiocas.Length; i++) {
		
			tapiocas[i].GetComponent<Rigidbody>().useGravity = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= limit) {

			//どのタピオカにするか決める
			int randIndex = Random.Range (0, tapiocas.Length);
			tapiocas[randIndex].GetComponent<Rigidbody>().useGravity = true;

			timer = 0;
		}
	}
}