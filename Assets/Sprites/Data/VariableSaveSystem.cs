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
    public int plusFavor;


    private void Update()
    {
        maleFavor.text = gameFlowchart.GetIntegerVariable("顏建鴻").ToString();
        femaleFavor.text = gameFlowchart.GetIntegerVariable("楊芝妤").ToString();

        int newMaleFavor;
        int newFemaleFavor;
    }

    public void IncreaseValue()
    {
        IntegerVariable maleVariable = gameFlowchart.GetVariable<IntegerVariable>("顏建鴻");
        IntegerVariable femaleVariable = gameFlowchart.GetVariable<IntegerVariable>("楊芝妤");

        int maleCurrentValue = maleVariable.Value;
        int femaleCurrentValue = femaleVariable.Value;
 
        int newMaleCurrentValue = maleCurrentValue + plusFavor;
        int newFemaleCurrentValue = femaleCurrentValue + plusFavor;

        maleVariable.Value = newMaleCurrentValue;
        femaleVariable.Value = newFemaleCurrentValue;
    }
}
