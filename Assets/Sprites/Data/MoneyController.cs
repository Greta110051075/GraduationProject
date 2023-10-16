using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour
{
    public Text numberText;
    public int number = 0;

    void Start()
    {
        UpdateNumberText();
    }

    public void IncreaseNumber()
    {
        number++;
        UpdateNumberText();
    }

    void UpdateNumberText()
    {
        if (numberText != null)
        {
            numberText.text = "Number: " + number;
        }
    }
}
