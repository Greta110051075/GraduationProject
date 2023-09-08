using Fungus;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;
using UnityEngine.UI;
using Fungus;


public class NameinputAppear : MonoBehaviour
{
    public GameObject inputField;
    public GameObject button;
    public GameObject word;
    public string nameInput;
    public Flowchart flowchart;
    public Flowchart gameFlowchart;
    public static NameinputAppear instance;

    private BooleanVariable isNameInput;

    public string variableName = "PlayerName";

    private void Awake()
    {
        isNameInput = flowchart.GetVariable<BooleanVariable>(nameInput);

    }

    private void Update()
    {
        if (isNameInput == true)
        {
            flowchart.StopAllBlocks();
        }
        else
        {
            flowchart.IsActive();
        }
    }

    public void AskCheck()
    {
        word.SetActive(true);
        isNameInput.Value = false;

    }

    public void Check()
    {
        word.SetActive(false);
        button.SetActive(false);
        inputField.SetActive(false);
        isNameInput.Value = true;
        StartFlowchart();
    }

    private void StartFlowchart()
    {
        gameFlowchart.ExecuteBlock("GameStart");
    }

  

}
