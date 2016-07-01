using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ObjectSelection : MonoBehaviour {

    public GameObject[] list;
   
    private void SetActiveList()
    {
        for (int i = 0; i < list.Length; i++) 
            list[i].SetActive(false);
    }

    void Start() 
    {
        SetActiveList();
    }

    public void ItemOnClick() 
    {
        SetActiveList();
        list[0].SetActive(true);
    }

    public void Item1OnClick() 
    {
        SetActiveList();
        list[1].SetActive(true);
    }

    public void Item2OnClick() 
    {
        SetActiveList();
        list[2].SetActive(true);
    }

    public void Item3OnClick()
    {
        SetActiveList();
        list[3].SetActive(true);
    }

    public void Item4OnClick()
    {
        SetActiveList();
        list[4].SetActive(true);
    }

    public void Item5OnClick()
    {
        SetActiveList();
        list[5].SetActive(true);
    }
   
}
