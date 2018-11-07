using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

	public GameObject[] obj;
	public float spawnMin = 1f;
	public float spawnMax = 2f;

	// Use this for initialization
	void Start () {
		Spawner ();
	}

	void Spawner()
	{
		Instantiate(obj[Random.Range (0, obj.GetLength(0))], transform.position, Quaternion.identity);
		Invoke ("Spawner", Random.Range (spawnMin,spawnMax));
	}

}
