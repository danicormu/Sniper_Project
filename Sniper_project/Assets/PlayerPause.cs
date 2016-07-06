using UnityEngine;
using System.Collections;

public class PlayerPause : MonoBehaviour {

	public GameObject pauseMenu;
	// Use this for initialization
	void Start () {
		pauseMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && Time.timeScale == 1) {
			MouseLock.MouseLocked = false;
			pauseMenu.SetActive (true);
			Time.timeScale = 0;
		} else if (Time.timeScale == 0 && Input.GetKeyDown (KeyCode.Escape)) {
			pauseMenu.SetActive (false);
			MouseLock.MouseLocked = true;
			Time.timeScale = 1;
		}
	}
}
