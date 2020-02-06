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

        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1) || Input.GetKeyDown(KeyCode.Keypad1))
        {
            activeStep = activeStep.exitFirst;
            contentTextVar.text = activeStep.content;
        }
        else if (Input.GetKeyDown(KeyCode.Alpha2) || Input.GetKeyDown(KeyCode.Keypad2))
        {
            activeStep = activeStep.exitSecond;
            contentTextVar.text = activeStep.content;
        }

    }
}
