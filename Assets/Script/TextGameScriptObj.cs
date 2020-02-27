using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextGameScriptObj : MonoBehaviour
{
    
    [Header("Elements")]
    public Text titleTextVar;
    public Text contentTextVar;
    public Image contentImageVar;


    [Header("Config")]
    [Tooltip("Название игры")] public string title = "Game Title";
    
    public StepData activeStep;
    public StepData startStep;


 
    void GameUpdate()
    {
        titleTextVar.text = activeStep.title;
        contentTextVar.text = activeStep.content;
        contentImageVar.sprite = activeStep.stepImage;



    }



    void Start()
    {

      
        GameUpdate();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            CheckPress(1);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            CheckPress(2);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            CheckPress(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            CheckPress(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            CheckPress(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            CheckPress(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            CheckPress(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            CheckPress(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            CheckPress(9);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            activeStep = startStep;
            GameUpdate();
        }
    }
    void CheckPress(int index)
    {
        if ((activeStep.nextSteps.Length > index) && activeStep.nextSteps[index] != null)
        {
           
                activeStep = activeStep.nextSteps[index];


                GameUpdate();
         }
        else
        {
                activeStep = activeStep.nextSteps[1];
                
                GameUpdate();
        }


        }
    }
