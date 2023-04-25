using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Slot : MonoBehaviour
{

    public int[] symbols; // 該滾輪上的符號

    private int currentSymbolIndex; // 當前顯示的符號索引
    private float spinSpeed; // 滾輪旋轉速度
    private bool isSpinning; // 是否正在旋轉
    private float targetSpinSpeed; // 旋轉目標速度
    private int targetSymbolIndex; // 目標符號索引

    void Start()
    {
        isSpinning = false;
        spinSpeed = 0f;
    }

    void Update()
    {
        if (isSpinning)
        {
            // 如果滾輪正在旋轉，則旋轉滾輪並減緩旋轉速度，直到達到目標速度
            transform.Rotate(Vector3.forward * spinSpeed * Time.deltaTime);
            spinSpeed = Mathf.Lerp(spinSpeed, targetSpinSpeed, Time.deltaTime * 5f);
            if (Mathf.Abs(spinSpeed - targetSpinSpeed) < 0.1f)
            {
                // 如果速度接近目標速度，則將滾輪停止在目標符號上
                currentSymbolIndex = targetSymbolIndex;
                isSpinning = false;
            }
        }
    }

    public void Spin(float speed, int targetIndex)
    {
        // 開始旋轉滾輪
        targetSpinSpeed = speed;
        targetSymbolIndex = targetIndex;
        isSpinning = true;
    }

    public int GetCurrentSymbolIndex()
    {
        // 返回當前滾輪上的符號索引
        return symbols[currentSymbolIndex];
    }
}
