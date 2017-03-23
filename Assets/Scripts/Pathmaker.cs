using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathmaker : MonoBehaviour {

	private int counter;

	public Transform floorPrefab;
	public Transform spherePrefab;

	float probToTurnRight;
	float probToTurnLeft;
	float probToSpawn;

	public static int globalFloorCount = 0;

	// Use this for initialization
	void Start () {
		counter = 0;
		probToTurnRight = Random.Range (0.05f, 0.075f);
		probToTurnLeft = Random.Range (0.2f, 0.3f);
		probToSpawn = Random.Range (0.97f, 0.99f);
		//this.gameObject.SetActive (true);
	}

	// Update is called once per frame
	void Update () {
		if (counter < 50 && globalFloorCount <= 500) {
			float randomNumber = Random.Range (0f, 1f);
			if (randomNumber < 0.98f) {
				if (randomNumber < probToTurnRight) {
					transform.Rotate (0f, 90f, 0f);
				} else if (randomNumber > 0.1f && randomNumber < 0.15f) {
					transform.Rotate (0f, -90f, 0f);
				}
			} else if (randomNumber >= probToSpawn) {
				Instantiate (spherePrefab, transform.position, Quaternion.identity);
			}

			Instantiate (floorPrefab, transform.position, Quaternion.identity);
			transform.Translate (new Vector3 (0f, 0f, 5f), Space.Self);

			counter -= 1;
			globalFloorCount++;
		} else {
			Destroy (this.gameObject);
		}
			
	}
}
