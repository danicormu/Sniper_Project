using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerPause : MonoBehaviour {

	public GameObject pauseMenu;
    public Behaviour[] components;
	// Use this for initialization
	void Start () {
		pauseMenu.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape) && Time.timeScale == 1) {
			MouseLock.MouseLocked = false;
            for (int i = 0; i < components.Length; i++)
                components[i].enabled = false;
            pauseMenu.SetActive(true);
			Time.timeScale = 0;
		} else if (Time.timeScale == 0 && Input.GetKeyDown (KeyCode.Escape)) {
			pauseMenu.SetActive (false);
			MouseLock.MouseLocked = true;
            for (int i = 0; i < components.Length; i++)
                components[i].enabled = true;
			Time.timeScale = 1;
		}
	}

    public void ResumeGame() 
    {
        pauseMenu.SetActive(false);
        MouseLock.MouseLocked = true;
        for (int i = 0; i < components.Length; i++)
            components[i].enabled = true;
        Time.timeScale = 1;
    }

    public void QuitGame() 
    {
        for (int i = 0; i < components.Length; i++)
            components[i].enabled = true;
        SceneManager.LoadScene("HeadQuarter");
    }
}
