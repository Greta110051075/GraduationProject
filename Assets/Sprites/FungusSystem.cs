using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class FungusSystem : MonoBehaviour
{
    public Flowchart flowchart;
    public Text uiText;
    public string valueName;
    int newValue;

    private void Start()
    {
       // newValue = flowchart.GetIntegerVariable(valueName);
    }

    private void Update()
    {
        newValue = flowchart.GetIntegerVariable(valueName);

        uiText.text = newValue.ToString();
    }
}



