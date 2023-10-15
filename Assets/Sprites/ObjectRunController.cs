using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectController : MonoBehaviour
{
    private bool isRunning = true;

    public TextMeshProUGUI moneyText; // 顯示所持金的 UI
    public int money; // 玩家所持金額

    public GameObject gameSta

    public TextMeshProUGUI plusMoneyText;
    public int plusMoney;

    private void Start()
    {
        UpdateMoneyText();
        UpdatePlusMoneyText();
    }

    private void Update()
    {
        if (isRunning)
        {
            // 此处放置物体的行为代码
        }
    }

    public void SetRunningState(bool state)
    {
        isRunning = state;
    }

    public void UpdateMoneyText()
    {
        moneyText.text = money.ToString();
    }

    public void UpdatePlusMoneyText()
    {
        plusMoneyText.text = plusMoney.ToString();
    }

    public void ButtonClick()
    {
        money -= plusMoney;
        plusMoney = 0;
        UpdateMoneyText();
        UpdatePlusMoneyText();
    }
}

