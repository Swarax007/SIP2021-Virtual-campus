using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;
    
 

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("InterObj"))
        {
            currentInterObj = other.gameObject;
            
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("InterObj"))
        {
            if (other.gameObject == currentInterObj)
            {
                currentInterObj = null;
            }
            
        }
    }
    
    private void Update()
    {

        if (Input.GetButtonDown("Interact") && currentInterObj) 
        {
            //Do something with object
            
            currentInterObj.SendMessage("DoInteraction");
        }
       
         
    }
}
