using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    public string title;
    [TextArea(minLines: 10, maxLines: 20)] public string content;
    public Sprite stepImage;
    public int eventNumber;
    public int eventChangeNumber;
    public Step[] nextSteps;
    public int[] stuffNeed;
}
