﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pathmaker : MonoBehaviour {

	private int counter;

	public Transform floorPrefab;
	public Transform spherePrefab;

	public GameObject[] myPrefabs = new GameObject[3];

	float probToTurnRight;
	float probToTurnLeft;
	float probToSpawn;
	int lifeSpan;

	public static int globalFloorCount = 0;

	GameObject gameManager;
	GameManager gmScript;
//	float minX;
//	float maxX;
//	float minZ;
//	float maxZ;

	// Use this for initialization
	void Start () {
		counter = 0;
		probToTurnRight = Random.Range (0.05f, 0.06f);
		probToTurnLeft = Random.Range (0.2f, 0.3f);
		probToSpawn = Random.Range (0.98f, 0.99f);
		lifeSpan = Random.Range (30, 35);

		gameManager = GameObject.Find ("Game Manager");
		gmScript = gameManager.GetComponent<GameManager> ();
		//this.gameObject.SetActive (true);
	}
		

	// Update is called once per frame
	void Update () {
		if (counter < lifeSpan && globalFloorCount <= 500) {
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
				
			float randomTile = Random.Range (0f, 3f);
			if (randomTile < 0.5f) {
				Instantiate (myPrefabs [0], transform.position, Quaternion.identity);
				if (this.transform.position.x < gmScript.negativeX) {
					gmScript.negativeX = this.transform.position.x;
				} 
				if (this.transform.position.x > gmScript.positiveX) {
					gmScript.positiveX = this.transform.position.x;
				}
				if (this.transform.position.z < gmScript.negativeZ) {
					gmScript.negativeZ = this.transform.position.z;
				}
				if (this.transform.position.z > gmScript.negativeZ) {
					gmScript.negativeZ = this.transform.position.z;
				}
			} else if (randomTile < 0.7f) {
				Instantiate (myPrefabs [1], transform.position, Quaternion.identity);
				if (this.transform.position.x < gmScript.negativeX) {
					gmScript.negativeX = this.transform.position.x;
				} 
				if (this.transform.position.x > gmScript.positiveX) {
					gmScript.positiveX = this.transform.position.x;
				}
				if (this.transform.position.z < gmScript.negativeZ) {
					gmScript.negativeZ = this.transform.position.z;
				}
				if (this.transform.position.z > gmScript.negativeZ) {
					gmScript.negativeZ = this.transform.position.z;
				}
			} else {
				Instantiate (myPrefabs[2], transform.position, Quaternion.identity);
				if (this.transform.position.x < gmScript.negativeX) {
					gmScript.negativeX = this.transform.position.x;
				} 
				if (this.transform.position.x > gmScript.positiveX) {
					gmScript.positiveX = this.transform.position.x;
				}
				if (this.transform.position.z < gmScript.negativeZ) {
					gmScript.negativeZ = this.transform.position.z;
				}
				if (this.transform.position.z > gmScript.negativeZ) {
					gmScript.negativeZ = this.transform.position.z;
				}
			}
//			Instantiate (floorPrefab, transform.position, Quaternion.identity);
			transform.Translate (new Vector3 (0f, 0f, 5f), Space.Self);

			counter -= 1;
			globalFloorCount++;
		} else {
			Destroy (this.gameObject);
		}
			
	}
}
