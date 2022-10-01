using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LeftButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField]
    MainObject mainObject;
    
 
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        mainObject.onLeftArrowPress();
    }

}
