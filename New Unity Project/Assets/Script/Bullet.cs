using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float BulletSpeed;

	Vector3 Direction;

	private void Start()
	{
		Destroy(gameObject, 100);
	}
	void Update ()
	{
		var translate = Direction * Time.deltaTime * BulletSpeed;
		transform.Translate(translate);
	}

	public void ShootBullet(Vector3 direction, Vector3 pos)
	{
		transform.position = pos;
		Direction = direction;
	}
}
