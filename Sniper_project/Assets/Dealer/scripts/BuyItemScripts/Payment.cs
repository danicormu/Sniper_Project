using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Payment : MonoBehaviour {

    public GameObject[] cardImages;
    public Text CVV;
    public Text CardNumber;
    public Text BillingAdd;
    public Text expDate;
    public GameObject message;
    public GameObject store;
    public GameObject buyItem;

	
    private void SetCardImages()
    {
        for (int i = 0; i < cardImages.Length; i++)
            cardImages[i].SetActive(false);
    }

	void Start () {
        SetCardImages();
        message.SetActive(false);
	}

    public void MasterCard() 
    {
        SetCardImages();
        cardImages[0].SetActive(true);
    }

    public void VisaCard() 
    {
        SetCardImages();
        cardImages[1].SetActive(true);
    }

    public void AmexCard() 
    {
        SetCardImages();
        cardImages[2].SetActive(true);
    }

    public void BuyOnClick() 
    {
        if (CardNumber.text != "" && expDate.text != "" && CVV.text != "" && BillingAdd.text != "")
            message.SetActive(true);
       
    }

    public void ConfirmationClicked() 
    {
        message.SetActive(false);
        buyItem.SetActive(false);
        store.SetActive(true);
    }

    public void CancelOnclick() 
    {
        buyItem.SetActive(false);
        store.SetActive(true);
    }
	

}
