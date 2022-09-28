using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Continue_Button_Script : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    GameObject PauseMenu;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        PauseMenu.SetActive(false);
    }
}
