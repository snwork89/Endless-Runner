using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseButtonScript : MonoBehaviour,IPointerClickHandler
{
    [SerializeField]
    GameObject pauseMenu;
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        pauseMenu.SetActive(true);
    }
}

