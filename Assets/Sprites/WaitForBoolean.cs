using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Fungus;

public class WaitForBoolean : MonoBehaviour
{
    public Flowchart flowchart;
    public string booleanVariableName;

    private bool waitForVariable = true;

    public void WaitUntilVariableIsTrue()
    {
        // 創建一個自定義的 Flowchart 命令，等待變數變為 true 時執行
        flowchart.ExecuteBlock("WaitForVariable");

        // 等待變數變為 true
        StartCoroutine(WaitForVariable());
    }

    private IEnumerator WaitForVariable()
    {
        while (!waitForVariable)
        {
            yield return null;
        }

        // 變數變為 true，執行接下來的命令
        flowchart.ExecuteBlock(flowchart.GetExecutingBlocks()[0]);
    }

    public void SetVariableToTrue()
    {
        // 將變數設為 true，開始執行等待的命令
        waitForVariable = true;
    }

    public void SetVariableToFalse()
    {
        // 將變數設為 false，停止等待的命令
        waitForVariable = false;
    }
}





