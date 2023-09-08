using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FavorSystem : MonoBehaviour
{
    public static int favor;
    public Text showFavor;

    void Start()
    {
        favor = 0;   
    }

    void Update()
    {
        show();
    }

    private void show()
    {
        showFavor.text = "favor:" + favor.ToString();
    }
}
