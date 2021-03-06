﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPerson : MonoBehaviour
{
	public float HP = 100;
	public float JumpSpeed = 2;
	public Transform Camera;
	public Gun PlayerGun;
	Rigidbody rigidbody;
	void Start ()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	float horizontalSpeed = 2.0f;
	float verticalSpeed = 2.0f;
	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			Vector3 force = Vector3.up * JumpSpeed;
			rigidbody.AddForce(force);
		}
		var forward = Input.GetAxis("Vertical");
		var sideways = Input.GetAxis("Horizontal");
		var forwardDirection = new Vector3(Camera.forward.x, 0, Camera.forward.z);
		var sidewaysDirection = new Vector3(Camera.right.x, 0, Camera.right.z);

		var finaldirection = ((sidewaysDirection * sideways) + (forwardDirection*forward)).normalized;
		var translate = finaldirection * 4 * Time.deltaTime;
		transform.Translate(translate);

		Debug.DrawLine(PlayerGun.SpawnPosition.position, (Camera.transform.position + (Camera.forward * 10)), Color.red);
		if (Input.GetMouseButtonDown(0) && PlayerGun.CanShoot)
		{
			var dir =  (Camera.transform.position + (Camera.forward * 15)) - PlayerGun.SpawnPosition.position;
			PlayerGun.Shoot(dir.normalized);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);

		HP -= 10;

		if(HP <= 0)
			Destroy(gameObject);
	}
}
