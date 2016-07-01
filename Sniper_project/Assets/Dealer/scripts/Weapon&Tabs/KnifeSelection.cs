using UnityEngine;
using System.Collections;

public class KnifeSelection : MonoBehaviour {

    public GameObject[] knifeList;

    private void SetKnifeActive()
    {
        for (int i = 0; i < knifeList.Length; i++)
            knifeList[i].SetActive(false);
    }

	
	void Start () {
        SetKnifeActive();
	}

    public void Knife0OnClick() 
    {
        SetKnifeActive();
        knifeList[0].SetActive(true);
    }

    public void Knife1OnClick()
    {
        SetKnifeActive();
        knifeList[1].SetActive(true);
    }

    public void Knife2OnClick()
    {
        SetKnifeActive();
        knifeList[2].SetActive(true);
    }

    public void Knife3OnClick()
    {
        SetKnifeActive();
        knifeList[3].SetActive(true);
    }

    public void Knife4OnClick()
    {
        SetKnifeActive();
        knifeList[4].SetActive(true);
    }

    public void Knife5OnClick()
    {
        SetKnifeActive();
        knifeList[5].SetActive(true);
    }
}
