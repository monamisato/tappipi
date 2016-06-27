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
		tapiocas = GameObject.FindGameObjectsWithTag ("Tapioca");
		limit = 5 + Random.Range (1.0f, 2.0f);

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