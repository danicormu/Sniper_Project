using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TabsScript : MonoBehaviour
{
    public GameObject rifles;
    public GameObject guns;
    public GameObject knives;
    public GameObject scopes;

    void Start() 
    {
        rifles.SetActive(true);
        guns.SetActive(false);
        knives.SetActive(false);
        scopes.SetActive(false);
    }

    public void RiflesOnClick() 
    {
        rifles.SetActive(true);
        guns.SetActive(false);
        knives.SetActive(false);
        scopes.SetActive(false);
    }

    public void GunsOnClick() 
    {
        rifles.SetActive(false);
        guns.SetActive(true);
        knives.SetActive(false);
        scopes.SetActive(false);
    }

    public void KnivesOnClick() 
    {
        rifles.SetActive(false);
        guns.SetActive(false);
        knives.SetActive(true);
        scopes.SetActive(false);
    }

    public void ScopesOnclick() 
    {
        rifles.SetActive(false);
        guns.SetActive(false);
        knives.SetActive(false);
        scopes.SetActive(true);
    }
}
