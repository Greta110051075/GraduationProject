using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{

    public TextMeshProUGUI moneyText; //��ܩҫ�����ui
    public int money; //���a�ҫ����B

    private void Start()
    {
        UpdateMoneyText(); // �b Start ��k����l�� UI �奻
    }

    public void UpdateMoneyText()
    {
        moneyText.text = "" + money.ToString(); // ��s UI �奻���
        Debug.Log("���ڦ��\");
    }

    private void Update()
    {
       // moneyText.text ="" + money;
    }
}
