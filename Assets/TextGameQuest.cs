using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextGameQuest : MonoBehaviour
{
    [Header("Elements")]
    public Text titleTextVar;
    public Text contentTextVar;

    [Header("Config")]
    [Tooltip("Game title")] public string title = "Game Title";

    public Step activeStep;

    // Start is called before the first frame update
    void Start()
    {
        titleTextVar.text = title;
        contentTextVar.text = activeStep.content;
        //string[] weekDays = { "Sunday", "Monday", "Tuesday", "Wenesday", "Thursday", "Friday", "Saturday" };
        //Debug.Log(weekDays[6]);
        //Debug.Log(weekDays.Length);


    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            CheckPress(0)
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            CheckPress(1)
        }
        else if (Input.GetKeyDown(KeyCode.Alpha3) || Input.GetKeyDown(KeyCode.Keypad3))
        {
            CheckPress(2)
        }
        else if (Input.GetKeyDown(KeyCode.Alpha4) || Input.GetKeyDown(KeyCode.Keypad4))
        {
            CheckPress(3)
        }
        else if (Input.GetKeyDown(KeyCode.Alpha5) || Input.GetKeyDown(KeyCode.Keypad5))
        {
            CheckPress(4)
        }
    }
    void CheckPress(int index)
    {
        if ((activeStep.nextSteps.Length > index) && activeStep.nextSteps[index] != null)
        {
            activeStep = activeStep.nextSteps[index];
            contentTextVar.text = activeStep.content;
        }
    }
}
