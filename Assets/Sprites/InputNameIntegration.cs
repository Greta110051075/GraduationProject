using System.Collections;
using UnityEngine;
using Fungus;
using UnityEngine.UI;

public class InputNameIntegration : MonoBehaviour
{
    public InputField inputField;
    public Flowchart flowchart;

    private string playerName;

    public void SubmitName()
    {
        // 獲取玩家輸入的名字
        string playerName = inputField.text;

        // 在 Fungus 變數中存儲名字
        flowchart.SetStringVariable("玩家名稱", playerName);

        // 觸發 Fungus Flowchart 開始執行
        flowchart.ExecuteBlock("CharacterName");
    }


    public void SavePlayerName()
    {
        playerName = inputField.text;
    }
}
