using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

	public Bullet BulletPrefab;
	public Transform SpawnPosition;
	public float ReloadTime = 1;

	public bool CanShoot {get{ return reloadTimer > ReloadTime;}}


	float reloadTimer;

	void Update ()
	{
		reloadTimer += Time.deltaTime;
	}

	public void Shoot(Vector3 direction)
	{
		var newcurrentBullet = Instantiate(BulletPrefab);
		newcurrentBullet.ShootBullet(transform.forward, SpawnPosition.position);
		reloadTimer = 0;
	}
}
