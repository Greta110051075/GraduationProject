using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VariableSaveSystem : MonoBehaviour
{
    public Flowchart gameFlowchart;
    public Text maleFavor;
    public Text femaleFavor;
    public Text money;
    public int plusFavor;


    private void Update()
    {
        maleFavor.text = gameFlowchart.GetIntegerVariable("顏建鴻").ToString();
        femaleFavor.text = gameFlowchart.GetIntegerVariable("楊芝妤").ToString();
        money.text = gameFlowchart.GetIntegerVariable("錢").ToString();

        int newMaleFavor;
        int newFemaleFavor;
        int newMoney;
    }

    public void IncreaseValue()
    {
        IntegerVariable maleVariable = gameFlowchart.GetVariable<IntegerVariable>("顏建鴻");
        IntegerVariable femaleVariable = gameFlowchart.GetVariable<IntegerVariable>("楊芝妤");
        IntegerVariable moneyVariable = gameFlowchart.GetVariable<IntegerVariable>("錢");

        int maleCurrentValue = maleVariable.Value;
        int femaleCurrentValue = femaleVariable.Value;
        int moneyCurrentValue = moneyVariable.Value;
 
        int newMaleCurrentValue = maleCurrentValue + plusFavor;
        int newFemaleCurrentValue = femaleCurrentValue + plusFavor;
        int newMoneyCurrentValue = moneyCurrentValue + plusFavor;

        maleVariable.Value = newMaleCurrentValue;
        femaleVariable.Value = newFemaleCurrentValue;
        moneyVariable.Value = newMoneyCurrentValue;
    }
}
