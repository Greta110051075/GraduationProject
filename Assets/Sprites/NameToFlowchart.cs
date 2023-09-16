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
        inputName.onValueChanged.AddListener(SyncInputToVariable); // 當 Input Field 文字更改時觸發 SyncInputToVariable 方法
    }


    private void SyncInputToVariable(string inputText)
    {
        gameFlowchart.SetStringVariable(variableName, inputText); // 將輸入的文字設定到指定的 String Variable
        gameCH2Flowchart.SetStringVariable(variableName, inputText);
        gameCH3Flowchart.SetStringVariable(variableName, inputText);
        missionFlowchart.SetStringVariable(variableName, inputText);
    }
}
