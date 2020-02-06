using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step : MonoBehaviour
{
    [TextArea(minLines: 10, maxLines: 20)] public string content;
    public Step exitFirst;
    public Step exitSecond;
}
