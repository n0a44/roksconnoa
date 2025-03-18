using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DoorInteraction : MonoBehaviour
{
    public GameObject doorAnimator;  
    

    private void Start()
    {
        if (doorAnimator == null)
        {
           
            doorAnimator.SetActive(false);
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CheckForDoorClick();
        }
    }

    private void CheckForDoorClick()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.collider != null && hit.collider.gameObject == gameObject)  
            {
               
                if (doorAnimator != null)
                {
                    doorAnimator.SetActive(true); 
                }
            }
        }
    }
}

