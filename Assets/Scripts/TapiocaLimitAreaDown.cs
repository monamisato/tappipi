using UnityEngine;
using System.Collections;

public class TapiocaLimitAreaUp : MonoBehaviour {

	float y = 0.0f;

	void Update ()
	{

		y = transform.position.y;	

		if (y < -5) {
			transform.position = new Vector3 (transform.position.x, -5, 0);

		
			}
		}
	}