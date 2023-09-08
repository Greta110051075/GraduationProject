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
        maleFavor.text = gameFlowchart.GetIntegerVariable("�C���E").ToString();
        femaleFavor.text = gameFlowchart.GetIntegerVariable("���ۧ�").ToString();

        int newMaleFavor;
        int newFemaleFavor;
    }

    public void IncreaseValue()
    {
        IntegerVariable maleVariable = gameFlowchart.GetVariable<IntegerVariable>("�C���E");
        IntegerVariable femaleVariable = gameFlowchart.GetVariable<IntegerVariable>("���ۧ�");

        int maleCurrentValue = maleVariable.Value;
        int femaleCurrentValue = femaleVariable.Value;
 
        int newMaleCurrentValue = maleCurrentValue + plusFavor;
        int newFemaleCurrentValue = femaleCurrentValue + plusFavor;

        maleVariable.Value = newMaleCurrentValue;
        femaleVariable.Value = newFemaleCurrentValue;
    }
}
