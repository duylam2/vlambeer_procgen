using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public Transform spherePrefab;

	// Use this for initialization
	void Start () {
		Pathmaker.globalFloorCount = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.R)) {
			SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
		}
	}
}
