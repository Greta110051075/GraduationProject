using Fungus;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Search;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeSceneSystem : MonoBehaviour
{
    public GameObject computer;
    public GameObject room;
    public GameObject character;
    public GameObject voiceRegulate;
    public GameObject schedule;
    public GameObject gamingObject;
    public GameObject mainMenu;
    public Flowchart nameInputFlowchart;
    


    public void Computer()
    {
        computer.SetActive(true);
        room.SetActive(false);
    }
    
    public void back()
    {
        room.SetActive(true);
        computer.SetActive(false);

    }

    public void Menu()
    {
        mainMenu.SetActive(true);
        gamingObject.SetActive(false);
    }

    public void Gaming()
    {
        gamingObject.SetActive(true);
        mainMenu.SetActive(false);
    }

    public void Character()
    {
        character.SetActive(true);
    }

    public void BackCharacter()
    {
        character.SetActive(false);
    }

    public void VoiceRegulate()
    {
        voiceRegulate.SetActive(true);
    }

    public void BackVoice()
    {
        voiceRegulate.SetActive(false);
        Debug.Log("Button Clicked: BackVoice " );
    }

    public void Schedule()
    {
        schedule.SetActive(true);
    }

    public void BackSchedule()
    {
        schedule.SetActive(false);
    }

    private void StartFlowchart()
    {
        
        nameInputFlowchart.ExecuteBlock("NameInput");
    }
}
