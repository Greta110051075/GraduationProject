using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActiveControllerFalse : MonoBehaviour
{
    private void Awake()
    {
        gameObject.SetActive(false);
    }
}
