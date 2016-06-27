using UnityEngine;
using System.Collections;

public class TapiocaLimitAreaDown : MonoBehaviour {

	float y = 0.0f;

	void Update ()
	{

		y = transform.position.y;	

		if (y > -3) {
			transform.position = new Vector3 (transform.position.x, -3, 0);

			}
		}
	}
