using UnityEngine;
using System.Collections;

public class DotSpawner : MonoBehaviour {

	public GameObject[] obj;

	// Use this for initialization
	void Start () {
		//start spawning dots
		Spawn ();
	}

	void SpawnDot() {
		//get random coordinates
		var dotX = Random.Range (0.0f, 5.0f);
		var dotY = Random.Range (0.0f, 5.0f);
	}
}
