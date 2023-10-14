using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemPriceSystem : MonoBehaviour
{
    public MoneyController moneyController;
    public int itemPrice;

    public TextMeshProUGUI itemPriceText;

    public void Update()
    {
        itemPriceText.text = "" + itemPrice;
    }

    public void BuyItemWithButton()
    {
        if (moneyController.money >= itemPrice)
        {
            moneyController.money -= itemPrice; // 購買商品，扣款
            Debug.Log("購買成功");
            moneyController.UpdateMoneyText(); // 更新 UI 文本
        }
        else
        {
            Debug.Log("錢不夠！");
        }
    }
}
