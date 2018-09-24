using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public Transform Aim;

	float horizontalSpeed = 2.0f;
	float verticalSpeed = 2.0f;
	public float Distance = 5;
	void Update () {
		float h = horizontalSpeed * Input.GetAxis("Mouse X");
		float v = verticalSpeed * Input.GetAxis("Mouse Y");

		Aim.position += new Vector3(h, 0, 0);
		var direction = Aim.position - transform.position;
		Aim.position = direction.normalized * Distance + transform.position;
		transform.LookAt(Aim);
		//transform.Rotate(v, h, 0);

	}
}
