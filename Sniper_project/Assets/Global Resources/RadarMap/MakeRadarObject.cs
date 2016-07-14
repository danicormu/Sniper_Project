using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MakeRadarObject : MonoBehaviour {

	public Image image;
	// Use this for initialization
	void Start () {
		radarMap.RegisterRadarObject (this.gameObject, image);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnDestroy(){
		radarMap.RemoveRadarObjects (this.gameObject);
	}
}
