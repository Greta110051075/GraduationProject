using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyController : MonoBehaviour
{
    public TextMeshProUGUI moneyText; //顯示所持金的ui
    public int money; //玩家所持金額

    private void Start()
    {
        UpdateMoneyText(); // 在 Start 方法中初始化 UI 文本
    }

    public void UpdateMoneyText()
    {
        moneyText.text = "" + money.ToString(); // 更新 UI 文本顯示
        Debug.Log("扣款成功");
    }
}
