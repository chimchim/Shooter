using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float JumpSpeed = 2;
	public Gun PlayerGun;
	Rigidbody rigidbody;

	Transform player;

	private void OnEnable()
	{
		player = FindObjectOfType<FirstPerson>().transform;

		Debug.Log("OnEnable enemy");
	}

	void Update ()
	{
		
	}
}
