using UnityEngine;
using System.Collections;

public class GunSelection : MonoBehaviour {

	public GameObject[] gunList;

    private void SetActiveGunList()
    {
        for (int i = 0; i < gunList.Length; i++)
            gunList[i].SetActive(false);
    }
	
    void Start () {
        SetActiveGunList();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Gun0OnClick()
    {
        SetActiveGunList();
        gunList[0].SetActive(true);
    }

    public void Gun1OnClick()
    {
        SetActiveGunList();
        gunList[1].SetActive(true);
    }

    public void Gun2OnClick()
    {
        SetActiveGunList();
        gunList[2].SetActive(true);
    }

    public void Gun3OnClick()
    {
        SetActiveGunList();
        gunList[3].SetActive(true);
    }

    public void Gun4OnClick()
    {
        SetActiveGunList();
        gunList[4].SetActive(true);
    }

    public void Gun5OnClick()
    {
        SetActiveGunList();
        gunList[5].SetActive(true);
    }
}
