using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class Navigation : MonoBehaviour {

    //Where item will appear as parameters
    public Text itemName;
    public Text itemPrice;

    // Rifle parameters
    public Text rifle0Name;
    public Text rifle0Price;
    public Text rifle1Name;
    public Text rifle1Price;
    public Text rifle2Name;
    public Text rifle2Price;
    public Text rifle3Name;
    public Text rifle3Price;
    public Text rifle4Name;
    public Text rifle4Price;
    public Text rifle5Name;
    public Text rifle5Price;

    // Gun parameters
    public Text gun0Name;
    public Text gun0Price;
    public Text gun1Name;
    public Text gun1Price;
    public Text gun2Name;
    public Text gun2Price;
    public Text gun3Name;
    public Text gun3Price;
    public Text gun4Name;
    public Text gun4Price;
    public Text gun5Name;
    public Text gun5Price;

    //knives parameters
    public Text knife0Name;
    public Text knife0Price;
    public Text knife1Name;
    public Text knife1Price;
    public Text knife2Name;
    public Text knife2Price;
    public Text knife3Name;
    public Text knife3Price;
    public Text knife4Name;
    public Text knife4Price;
    public Text knife5Name;
    public Text knife5Price;

    // Scopes Parameters
    public Text scope0Name;
    public Text scope0Price;
    public Text scope1Name;
    public Text scope1Price;
    public Text scope2Name;
    public Text scope2Price;
    public Text scope3Name;
    public Text scope3Price;
    public Text scope4Name;
    public Text scope4Price;
    public Text scope5Name;
    public Text scope5Price;

    // in Game objects
    public GameObject buyObject;
    public GameObject parameters;
    public GameObject store;
    public Text BuyItemName;
    public Text BuyItemPrice;
    public GameObject userMoney;
    public Text playerMoney;
    public GameObject errorMessage;

    // variables
    string itemNameVar;
    string itemPriceVar;


    void Start() 
    {
        store.SetActive(true);
        buyObject.SetActive(false);
        parameters.SetActive(false);
        errorMessage.SetActive(false);
    }

    void Update() 
    {
        itemNameVar = itemName.text;
        itemPriceVar = itemPrice.text;
    }

    //Rifle Parameter Passing Methods
    public void PassRifle0Parameter()
    {
        itemName.text = rifle0Name.text;
        itemPrice.text = rifle0Price.text;
    }

    public void PassRifle1Parameter()
    {
        itemName.text = rifle1Name.text;
        itemPrice.text = rifle1Price.text;
    }

    public void PassRifle2Parameter()
    {
        itemName.text = rifle2Name.text;
        itemPrice.text = rifle2Price.text;
    }

    public void PassRifle3Parameter()
    {
        itemName.text = rifle3Name.text;
        itemPrice.text = rifle3Price.text;
    }

    public void PassRifle4Parameter()
    {
        itemName.text = rifle4Name.text;
        itemPrice.text = rifle4Price.text;
    }

    public void PassRifle5Parameter()
    {
        itemName.text = rifle5Name.text;
        itemPrice.text = rifle5Price.text;
    }

    // passing gun parameters methods
    public void PassGun0Parameters() 
    {
        itemName.text = gun0Name.text;
        itemPrice.text = gun0Price.text;
    }

    public void PassGun1Parameters()
    {
        itemName.text = gun1Name.text;
        itemPrice.text = gun1Price.text;
    }

    public void PassGun2Parameters()
    {
        itemName.text = gun2Name.text;
        itemPrice.text = gun2Price.text;
    }

    public void PassGun3Parameters()
    {
        itemName.text = gun3Name.text;
        itemPrice.text = gun3Price.text;
    }

    public void PassGun4Parameters()
    {
        itemName.text = gun4Name.text;
        itemPrice.text = gun4Price.text;
    }

    public void PassGun5Parameters()
    {
        itemName.text = gun5Name.text;
        itemPrice.text = gun5Price.text;
    }

    //knife parameters passing methods
    public void PassKnife0Parameters() 
    {
        itemName.text = knife0Name.text;
        itemPrice.text = knife0Price.text;
    }

    public void PassKnife1Parameters()
    {
        itemName.text = knife1Name.text;
        itemPrice.text = knife1Price.text;
    }

    public void PassKnife2Parameters()
    {
        itemName.text = knife2Name.text;
        itemPrice.text = knife2Price.text;
    }

    public void PassKnife3Parameters()
    {
        itemName.text = knife3Name.text;
        itemPrice.text = knife3Price.text;
    }

    public void PassKnife4Parameters()
    {
        itemName.text = knife4Name.text;
        itemPrice.text = knife4Price.text;
    }

    public void PassKnife5Parameters()
    {
        itemName.text = knife5Name.text;
        itemPrice.text = knife5Price.text;
    }

    //Scope Passing parametersmethods

    public void Scope1ParametersPass() 
    {
        itemName.text = scope1Name.text;
        itemPrice.text = scope1Price.text;
    }

    public void Scope2ParametersPass()
    {
        itemName.text = scope2Name.text;
        itemPrice.text = scope2Price.text;
    }

    public void Scope3ParametersPass()
    {
        itemName.text = scope3Name.text;
        itemPrice.text = scope3Price.text;
    }

    public void Scope4ParametersPass()
    {
        itemName.text = scope4Name.text;
        itemPrice.text = scope4Price.text;
    }

    public void Scope0ParametersPass()
    {
        itemName.text = scope0Name.text;
        itemPrice.text = scope0Price.text;
    }

    public void Scope5ParametersPass()
    {
        itemName.text = scope5Name.text;
        itemPrice.text = scope5Price.text;
    }

    public void GoBack() 
    {
        SceneManager.LoadScene("HeadQuarter");        
    }

    // Buy Buttom

    public void BuyOnClick() 
    {
        if (itemPrice.text.Equals("Buy On Store"))
        {
            store.SetActive(false);
            BuyItemName.text = itemNameVar;
            BuyItemPrice.text = "50$";
            buyObject.SetActive(true);
        }
        else 
        {
            double money = Convert.ToDouble(playerMoney.text);
            double price = Convert.ToDouble(itemPrice.text);
            if (money > price)
                playerMoney.text = (money - price).ToString();
            else
                errorMessage.SetActive(true);
        }
    }

    public void OkOnClick() 
    {
        errorMessage.SetActive(false);
    }




}
