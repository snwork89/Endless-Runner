using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class RightButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    MainObject mainObject;


    public void OnPointerClick(PointerEventData pointerEventData)
    {
        
        mainObject.onRightArrowPress();
    }
}
