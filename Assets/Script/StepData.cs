using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Step Data File")] //
public class StepData : ScriptableObject
{
    public string title;
    [TextArea(minLines: 10, maxLines: 20)] public string content;
    public Sprite stepImage;
    public StepData[] nextSteps;
}
