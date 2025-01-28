using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSelector : MonoBehaviour
{
    public Camera mainCamera;  
    public float rayDistance = 10f; 
    public LayerMask selectableLayer; 

    private GameObject selectedObject; 

    void Update()
    {
        
        Ray ray = mainCamera.ScreenPointToRay(new Vector2(Screen.width / 2, Screen.height / 2));
        RaycastHit hit;

        
        if (Physics.Raycast(ray, out hit, rayDistance, selectableLayer))
        {
            
            selectedObject = hit.collider.gameObject;

           
            Debug.Log("Raycast hit: " + selectedObject.name);

         
           
        }
        else
        {
          
            selectedObject = null;
        }
    }
}

