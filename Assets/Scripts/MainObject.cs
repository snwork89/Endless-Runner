using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainObject : MonoBehaviour
{
    private bool firstLane=true,secondLane=false,thirdLane = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(-1, 0, 0);
        transform.Translate(movement * 5.0f * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (firstLane == true)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, 10);
          
                secondLane = true;

                firstLane = false;
                thirdLane = false;
            }
            else if(secondLane==true)
            {
                   transform.position = new Vector3(transform.position.x, transform.position.y, 14);
                firstLane = false;
                secondLane = false;
                thirdLane = true;
                
            
            
            }
          
         
            

        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
  if (thirdLane == true)
            {    transform.position = new Vector3(transform.position.x, transform.position.y, 10);
                secondLane = true;

                firstLane = false;
                thirdLane = false;
            }
            else if(secondLane==true)
            {
                    transform.position = new Vector3(transform.position.x, transform.position.y, 0);
                firstLane = true;
                secondLane = false;
                thirdLane = false;
                
            
            
            }
        }
        
    }
}
