using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class MoneyCountSystem : MonoBehaviour
{
    public TextMeshProUGUI moneyIHaveText;
    public TextMeshProUGUI moneyPlusAllText;

    public int moneyhave;
    public int moneyPlusAll;

    public ItemPriceSystem itemPriceSystem;

    private void Start()
    {
        UpdateMoneyIHave();
        UpdateMoneyPlus();
        CleanCar();
    }

    private void Update()
    {
        moneyhave -= moneyPlusAll;
        UpdateMoneyIHave();

    }

    public void UpdateMoneyPlus()
    {
        moneyPlusAllText.text = "" + moneyPlusAll.ToString();
    }

    public void UpdateMoneyIHave()
    {
        moneyIHaveText.text = "" + moneyhave.ToString();
    }

    public void CleanCar()
    {
        moneyPlusAll = 0;
    }
}
