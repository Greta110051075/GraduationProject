using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlSoundSystem : MonoBehaviour
{
    public AudioSource audioSource;
    public Slider slider;

    public void ChangeVolume()
    {
        audioSource.volume = slider.value;
    }
}
