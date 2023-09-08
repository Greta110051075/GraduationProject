using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoveLevelSystem : MonoBehaviour
{
    public int npcFavorLevel = 0; // 當前好感度
    public int maxNpcFavorLevel = 100; //最高好感度
    public int currentFavor = 0; //當前好感度:
    public int maxFavor = 0; //升級好感度所需的值

    public int favorRangeMax = 50;
    public int favorRageMin = 10;

  
    private void Awake()
    {
    }

    private void Update()
    {
        FavorUpdateLevel(); //好感度升級體系 

        if (favorRangeMax > npcFavorLevel && favorRageMin <= npcFavorLevel)
        {

        }
    }

    //好感度升值體系
    public void FavorUpdateLevel()
    {
        maxFavor = 10 + npcFavorLevel * (npcFavorLevel + 1) * 5; //好感度最大數值變動

        if (currentFavor > maxFavor) //判斷好感度是否大於最大好感度
        {
            if(npcFavorLevel < maxNpcFavorLevel) //當前好感度等於當前好感度減去最大好感度
            {
                currentFavor = currentFavor - maxFavor;
                npcFavorLevel++;
            }
            else
            {
                currentFavor = maxFavor;
            }
        }
        else
        {
            if (npcFavorLevel < maxNpcFavorLevel) //判斷是否到最大值
            {
                currentFavor = 0;
                npcFavorLevel++;
            }
            else
            {
                currentFavor = maxFavor;
            }
        }       
    }



}