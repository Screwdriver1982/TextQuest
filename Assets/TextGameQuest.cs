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
    public Image locationImageVar;

    [Header("Config")]
    [Tooltip("Название игры")] public string title = "Game Title";
    [Tooltip("Всего ходов")] public int turnLeft = 10;
    [Tooltip("Предметов на старте")] public int[] stuff = { 100, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0};

    public Step activeStep;
    int[] eventsState = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

    // Start is called before the first frame update
    void Start()
    {
        titleTextVar.text = title;
        contentTextVar.text = activeStep.content;
        turnLeftTextVar.text = turnLeft.ToString();
        goldTextVar.text = stuff[0].ToString();
        locationImageVar.sprite = activeStep.stepImage;


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
            CheckPress(0);
        }
    }
    void CheckPress(int index)
    {
        bool stuffEnough = true;

        if ((activeStep.nextSteps.Length > index) && activeStep.nextSteps[index] != null)
        {
            turnLeft = turnLeft - 1;
            if (turnLeft >= 0)
            {

                activeStep = activeStep.nextSteps[index];

                if ((activeStep.eventNumber == 0) || eventsState[activeStep.eventNumber] == 0)
                {
                    for (int i = 0; i < 11; ++i)
                    {
                        if (stuff[i] >= activeStep.stuffNeed[i])
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
                        for (int j = 0; j < 11; ++j)
                        {
                            stuff[j] = stuff[j] - activeStep.stuffNeed[j];
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
                
                turnLeftTextVar.text = turnLeft.ToString();
                goldTextVar.text = stuff[0].ToString();
                contentTextVar.text = activeStep.content;
                locationImageVar.sprite = activeStep.stepImage;
            }
            else
            {
                activeStep = activeStep.nextSteps[1];
                contentTextVar.text = activeStep.content;
                locationImageVar.sprite = activeStep.stepImage;
            }


        }
    }
}
