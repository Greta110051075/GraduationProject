using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BuyPlusSystem : MonoBehaviour
{
    public MoneyController moneyController;
    public ItemPriceSystem itemPriceSystem;

    public TextMeshProUGUI plusMoneyText;
    public int plusMoney;



    public void Start()
    {
        UpdateMoneyText();
    }

    public void UpdateMoneyText()
    {
        plusMoneyText.text = "" + plusMoney.ToString();
        Debug.Log("加入購物車"); 

    }

    public void UpdateCartTotal(int cartTotal)
    {
       // plusMoney += itemPriceSystem.itemPrice;
        UpdateMoneyText();
    }

    public void ButtonClick()
    {
        int temporaryMoney = plusMoney;
        moneyController.money -= temporaryMoney;
        plusMoney = 0;
        UpdateMoneyText();
        moneyController.UpdateMoneyText();

    }
}
