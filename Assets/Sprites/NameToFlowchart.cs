using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameToFlowchart : MonoBehaviour
{
    private InputField inputName;

    public Flowchart gameFlowchart;
    public Flowchart gameCH2Flowchart;
    public Flowchart gameCH3Flowchart;
    public Flowchart missionFlowchart;
    public string variableName = "PlayerName";

    private void Start()
    {
        inputName = GetComponent<InputField>();
        inputName.onValueChanged.AddListener(SyncInputToVariable); // �� Input Field ��r����Ĳ�o SyncInputToVariable ��k
    }


    private void SyncInputToVariable(string inputText)
    {
        gameFlowchart.SetStringVariable(variableName, inputText); // �N��J����r�]�w����w�� String Variable
        gameCH2Flowchart.SetStringVariable(variableName, inputText);
        gameCH3Flowchart.SetStringVariable(variableName, inputText);
        missionFlowchart.SetStringVariable(variableName, inputText);
    }
}
