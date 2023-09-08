using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CrashSystem : MonoBehaviour
{
    public GameObject UI;
    private void Start()
    {
        UI.SetActive(false);
    }

    void OnCollisionEnter2D(Collision2D Car)
    {
        if (Car.gameObject.tag == "Car")
        {
            Destroy(gameObject);
            Time.timeScale = 0;
            UI.SetActive(true);
        }
    }
}
