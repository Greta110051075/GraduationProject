using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Camera cameraOne;
    public Camera cameraTwo;
    public GameObject walk;

    private void Start()
    {
        cameraOne.enabled = true;
        cameraTwo.enabled = false;
    }

    private void Update()
    {
        if (walk.activeSelf)
        {
            cameraTwo.enabled = true;
            cameraOne.enabled = false;
        }
        else
        {
            cameraOne.enabled = true;
            cameraTwo.enabled = false;
        }
    }
}
