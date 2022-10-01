using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainObject : MonoBehaviour
{
    private bool firstLane=false,secondLane=true,thirdLane =false;

    void Update()
    {
        Vector3 movement = new Vector3(-1, 0, 0);
        transform.Translate(movement * 5.0f * Time.deltaTime);
    }    
    

    public void onLeftArrowPress()
    {
        if (thirdLane == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10f);
            secondLane = true;

            firstLane = false;
            thirdLane = false;
        }
        else if (secondLane == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 6f);
            firstLane = true;
            secondLane = false;
            thirdLane = false;



        }
    }

    public void onRightArrowPress()
    {
        if (firstLane == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 10);

            secondLane = true;

            firstLane = false;
            thirdLane = false;
        }
        else if (secondLane == true)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 14f);
            firstLane = false;
            secondLane = false;
            thirdLane = true;



        }
    }
}
