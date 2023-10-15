using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemPriceSystem : MonoBehaviour
{
    public BuyPlusSystem buyPlusSystem;
    public MoneyController moneyController;
    public int itemPrice;
    public int cartTotal = 0;

    public TextMeshProUGUI itemPriceText;

    public void Update()
    {
        itemPriceText.text = "" + itemPrice;
    }

    public void BuyItemWithButton()
    {
        if (moneyController.money >= itemPrice)
        {
            buyPlusSystem.UpdateCartTotal(itemPrice); // 更新购物车的总金额
            buyPlusSystem.plusMoney += itemPrice; // 购买商品
            moneyController.UpdateMoneyText(); // 更新 UI 文本
            Debug.Log("購買成功");
        }
        else
        {
            Debug.Log("錢不夠！");
        }

        cartTotal += itemPrice;
    }

}
