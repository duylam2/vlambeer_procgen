using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Transform spherePrefab;

	public float negativeX;
	public float positiveX;
	public float negativeZ;
	public float positiveZ;

	// Use this for initialization
	void Start () {
		Pathmaker.globalFloorCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		for (int i = 0; i < Pathmaker.globalFloorCount; i++){
			Camera.main.transform.position = new Vector3 ((negativeX + positiveX) / 2, i/2, (negativeZ + positiveZ) / 2);
		}
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
