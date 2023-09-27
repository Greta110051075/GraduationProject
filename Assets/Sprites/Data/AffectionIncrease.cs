using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AffectionIncrease : MonoBehaviour
{
    public Flowchart flowchart;

    public string integerVariable;
    public string giftIdentifier; // 禮物的標示符號，會根據劇情來選擇

    public int value; //人物數值
    public int[] increaseValue;  

    public Image[] buttonImage; //顯示圖像

    private void Start()
    {

    }

    public void SendGift()
    {
        string selectedGift = GetSelectedGift();

        flowchart.ExecuteBlock(selectedGift); //執行fungus命令以增加好感度
    }
   
    private string GetSelectedGift() //根據故事發展選擇禮物
    {
        return giftIdentifier;
    }

    private void UpdateGiftImage()
    {

    }
}
 