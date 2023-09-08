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
        maleFavor.text = gameFlowchart.GetIntegerVariable("ÃC«ØÂE").ToString();
        femaleFavor.text = gameFlowchart.GetIntegerVariable("·¨ªÛ§±").ToString();

        int newMaleFavor;
        int newFemaleFavor;
    }

    public void IncreaseValue()
    {
        IntegerVariable maleVariable = gameFlowchart.GetVariable<IntegerVariable>("ÃC«ØÂE");
        IntegerVariable femaleVariable = gameFlowchart.GetVariable<IntegerVariable>("·¨ªÛ§±");

        int maleCurrentValue = maleVariable.Value;
        int femaleCurrentValue = femaleVariable.Value;
 
        int newMaleCurrentValue = maleCurrentValue + plusFavor;
        int newFemaleCurrentValue = femaleCurrentValue + plusFavor;

        maleVariable.Value = newMaleCurrentValue;
        femaleVariable.Value = newFemaleCurrentValue;
    }
}
