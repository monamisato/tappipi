using UnityEngine;
using System.Collections;

public class CupLimitAreaLeftRight : MonoBehaviour {
	
	float x = 0.0f;

	void Update ()
	{
		x = transform.position.x;	

		if (x < -4) {
			transform.position = new Vector3 (transform.position.x, -4, 0);

		}else if (x > 3.5) {
			transform.position = new Vector3 (transform.position.x, 3.5, 0);

			}
		}
	}