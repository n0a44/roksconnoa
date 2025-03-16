using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Selector : MonoBehaviour
{
    public Camera mainCamera;
    public float maxRaycastDistance = 10f;


    void Update()
    {
       
        Ray ray = mainCamera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, maxRaycastDistance))
        {
           

            if (hit.collider != null)
            {
               
                
                if (Input.GetMouseButtonDown(0)) 
                {
                    
                    InteractWithObject(hit.collider.gameObject);
                }
            }
        }
       
    }

    void InteractWithObject(GameObject obj)
    {
       
        Debug.Log("You interacted with: " + obj.name);
       
    }
}