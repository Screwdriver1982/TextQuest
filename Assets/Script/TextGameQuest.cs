using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextGameQuest : MonoBehaviour
{
    [Header("Elements")]
    public Text titleTextVar;
    public Text contentTextVar;
    public Text turnLeftTextVar;
    public Text goldTextVar;
    public Text blessTextVar;
    public Image blessImageVar;
    public Image locationImageVar;
    public Sprite blessImageExist;
    public Sprite blessImageNotExist;

    [Header("Config")]
    [Tooltip("Название игры")] public string title = "Game Title";
    [Tooltip("Всего ходов")] public int maxTurn = 10;
    [Tooltip("Предметов на старте")] public int[] startStuff = { 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};
    int turnLeft;
    int[] stuff = { 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    public Step activeStep;
    int[] startEventState = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    int[] eventsState = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    void StartGame()
    {
        for (int i = 0; i < eventsState.Length; ++i)
        {
            eventsState[i] = startEventState[i];
        }

        for (int i = 0; i < stuff.Length; ++i)
        {
            stuff[i] = startStuff[i];
        }
        turnLeft = Random.Range(maxTurn - 3, maxTurn + 3);
    }
    void GameUpdate()
    {
        titleTextVar.text = activeStep.title;
        contentTextVar.text = activeStep.content;
        if (eventsState[16] == 1)
        {
            turnLeftTextVar.text = turnLeft.ToString();
        }
        else
        {
            turnLeftTextVar.text = "Что-то будет";
        }
        goldTextVar.text = stuff[0].ToString();
        locationImageVar.sprite = activeStep.stepImage;
        if (eventsState[13] == 1)
        {
            blessTextVar.text = "Длань Юпитера";
            blessImageVar.sprite = blessImageExist;
        }
        else
        {
            blessTextVar.text = "";
            blessImageVar.sprite = blessImageNotExist;
        }
        
    }

    void GameEventStuffCheck()
    {
        bool stuffEnough = true;
        if ((activeStep.eventNumber == 0) || eventsState[activeStep.eventNumber] == 0)
        {
            for (int i = 0; i < 12; ++i)
            {
                if (stuff[i] + activeStep.stuffNeed[i] >= 0)
                {
                    stuffEnough = stuffEnough && true;
                }
                else
                {
                    stuffEnough = false;
                }

            }

            if (stuffEnough == true)
            {
                for (int j = 0; j < 12; ++j)
                {
                    stuff[j] = stuff[j] + activeStep.stuffNeed[j];
                }

                if (activeStep.eventChangeNumber == 1)
                {
                    eventsState[activeStep.eventNumber] = 1;
                }

            }
            else
            {
                activeStep = activeStep.nextSteps[2];
            }
        }
        else
        {
            activeStep = activeStep.nextSteps[2];
        }

    }

    void Start()
    {

        StartGame();
        GameUpdate();


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            CheckPress(3);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            CheckPress(4);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            CheckPress(5);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            CheckPress(6);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            CheckPress(7);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha6) || Input.GetKeyDown(KeyCode.Keypad6))
        {
            CheckPress(8);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha7) || Input.GetKeyDown(KeyCode.Keypad7))
        {
            CheckPress(9);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha8) || Input.GetKeyDown(KeyCode.Keypad8))
        {
            CheckPress(10);
        }
        else if (Input.GetKeyDown(KeyCode.Alpha9) || Input.GetKeyDown(KeyCode.Keypad9))
        {
            CheckPress(11);
        }
        else if (Input.GetKeyDown(KeyCode.Space) )
        {
            StartGame();
            CheckPress(0);
        }
    }
    void CheckPress(int index)
    {
        if ((activeStep.nextSteps.Length > index) && activeStep.nextSteps[index] != null)
        {
            turnLeft = turnLeft - 1;
            if (turnLeft >= 0)
            {

                activeStep = activeStep.nextSteps[index];


                GameEventStuffCheck();
                GameUpdate();
            }
            else
            {
                activeStep = activeStep.nextSteps[1];
                GameEventStuffCheck();
                GameUpdate();
            }


        }
    }
}
