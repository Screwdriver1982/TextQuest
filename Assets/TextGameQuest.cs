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
    [Tooltip("Game title")]public string title = "Game Title";
    
    [TextArea(minLines: 1, maxLines: 10)]public string content = "Content Text";

    // Start is called before the first frame update
    void Start()
    {
        titleTextVar.text = title;
        contentTextVar.text = content;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
