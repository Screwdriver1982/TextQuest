using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Step Data File")] //создает возможность в меню ассетов создать объект типа степ дата
public class StepData : ScriptableObject
{
    public string title;
    [TextArea(minLines: 10, maxLines: 20)] public string content;
    public Sprite stepImage;
    public StepData[] nextSteps;
}
