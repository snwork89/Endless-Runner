using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Main_Menu_Text_Script : MonoBehaviour,IPointerClickHandler
{
    public void OnPointerClick(PointerEventData pointerEventData)
    {
        SceneManager.LoadScene(0);
    }
}
