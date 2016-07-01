using UnityEngine;
using System.Collections;

public class ScopeSelection : MonoBehaviour {

    public GameObject[] scopesList;

    private void SetScopesActive()
    {
        for (int i = 0; i < scopesList.Length; i++)
            scopesList[i].SetActive(false);
    }

	void Start () {
        SetScopesActive();
	}

    public void Scope0Onclick() 
    {
        SetScopesActive();
        scopesList[0].SetActive(true);
    }

    public void Scope1Onclick()
    {
        SetScopesActive();
        scopesList[1].SetActive(true);
    }

    public void Scope2Onclick()
    {
        SetScopesActive();
        scopesList[2].SetActive(true);
    }

    public void Scope3Onclick()
    {
        SetScopesActive();
        scopesList[3].SetActive(true);
    }

    public void Scope4Onclick()
    {
        SetScopesActive();
        scopesList[4].SetActive(true);
    }

    public void Scope5Onclick()
    {
        SetScopesActive();
        scopesList[5].SetActive(true);
    }
}
