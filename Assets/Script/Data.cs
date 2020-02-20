using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data File")] // любое имя для пункта меню
public class Data : ScriptableObject  //особый тип объектов скриптов, которые нельзя привязывать к другим объектам, но можно использовать
{
    public string text;


}
