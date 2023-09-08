using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSystem : MonoBehaviour
{
    public string variableName;
    public Flowchart flowchart;
    public Text uiText;

    public void OnOptionClicked()
    {
    }

    public void OnOption2Clicked()
    {

    }

    private void UpdateValue(int newValue)
    {
        flowchart.SetIntegerVariable(variableName, flowchart.GetIntegerVariable(variableName) + newValue);

        uiText.text = flowchart.GetIntegerVariable(variableName).ToString();
    }
}
