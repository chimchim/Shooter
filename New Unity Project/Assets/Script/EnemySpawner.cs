using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	public GameObject EnemyPrefab;
	

	float timer;
	void Start ()
	{
		
	}

	void Update ()
	{
		timer -= Time.deltaTime;
		if (timer < 0)
		{
			timer = Random.Range(5, 10);
			var enemy = Instantiate(EnemyPrefab);
			enemy.transform.position = transform.position;
		}
	}
}
