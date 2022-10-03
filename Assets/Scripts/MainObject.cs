using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainObject : MonoBehaviour
{
    private bool firstLane=false,secondLane=true,thirdLane =false;
    public float speed = 15.0f;
    public GameObject spawnPrefab;
    void Update()
    {
        Vector3 movement = new Vector3(-1, 0, 0);
        transform.Translate(movement * speed * Time.deltaTime);

        
        if (((int)transform.position.x) % 300 == 0)
        {
            

           
            GameObject[] foundObjects = GameObject.FindGameObjectsWithTag("WorldPrefab");
            
            if (foundObjects.Length == 2)
            {
                Destroy(foundObjects[0]);
            }

            Instantiate(foundObjects[foundObjects.Length-1], new Vector3(transform.position.x + 60, 0, 0), transform.rotation);
        }
     
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
