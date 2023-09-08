using UnityEngine;
public class MusicControl : MonoBehaviour
{
    private AudioSource audioSource;//音量數值
    private bool muteState;//判斷是否為靜音
    private float preVolume;//紀錄靜音前音量
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = 0;
        muteState = false;
        preVolume = audioSource.volume;
    }
    public void VolumeChanged(float newVolume)
    {
        audioSource.volume = newVolume;
        muteState = false;
    }
    public void MuteClick()
    {
        muteState = !muteState;
        if (muteState)
        {
            preVolume = audioSource.volume;
            audioSource.volume = 0;
        }
        else
            audioSource.volume = preVolume;
    }
}