using UnityEngine;
using System.Collections;

public class cameras_moscu : MonoBehaviour {

	public Camera cam1 = new Camera ();
	public Camera cam2 = new Camera ();
	public Camera cam3 = new Camera ();
	public Camera cam4 = new Camera ();

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.A)) {
			cam1.enabled = true;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = false;
		} else if (Input.GetKey (KeyCode.S)) {
			cam1.enabled = false;
			cam2.enabled = true;
			cam3.enabled = false;
			cam4.enabled = false;
		} else if (Input.GetKey (KeyCode.D)) {
			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = true;
			cam4.enabled = false;
		} else if (Input.GetKey (KeyCode.S)) {
			cam1.enabled = false;
			cam2.enabled = false;
			cam3.enabled = false;
			cam4.enabled = true;
		}
	}
}
