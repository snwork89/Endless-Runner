using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Quit_Text_Script : MonoBehaviour,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        Application.Quit();
    }
}
