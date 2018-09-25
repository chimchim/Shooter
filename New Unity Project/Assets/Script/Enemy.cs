using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
	public float Speed = 5;
	public float JumpSpeed = 2;
	public Gun EnemyGun;
	Rigidbody rigidbody;

	Transform player;

	private void OnEnable()
	{
		player = FindObjectOfType<FirstPerson>().transform;
	}

	void Update ()
	{
		if (!player)
			return;

		var toPlayer = player.position - transform.position;
		if (toPlayer.magnitude > 10)
		{
			var translate = toPlayer.normalized * Time.deltaTime * Speed;
			transform.Translate(translate);
		}
		EnemyGun.transform.LookAt(player);
		if(EnemyGun.CanShoot)
		{
			EnemyGun.Shoot(toPlayer.normalized);
		}
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.tag == "PlayerBullet")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
