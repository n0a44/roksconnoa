using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DaRotationSCRIPT : MonoBehaviour
{
   
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Quaternion rot;

        rot = new Quaternion(90f, 0f, 0f, 0f);
        if (Input.GetMouseButtonDown(0))
        {
        
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Selectable"&&hit.transform.gameObject.GetComponent<CorrectPoz>().ok==false)
            {
                Debug.Log("lalala");


                hit.transform.gameObject.transform.Rotate(0,45,0);
                if (hit.transform.gameObject.transform.rotation.x == hit.transform.gameObject.GetComponent<CorrectPoz>().x) 
                hit.transform.gameObject.gameObject.GetComponent<CorrectPoz>().ok = true;
            }
        }
        if (Input.GetMouseButtonDown(1))
        {

            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Selectable" && hit.transform.gameObject.GetComponent<CorrectPoz>().ok == false)
            {
                Debug.Log("lalala");


                hit.transform.gameObject.transform.Rotate(0, -45, 0);
                if (hit.transform.gameObject.transform.rotation.x == hit.transform.gameObject.GetComponent<CorrectPoz>().x)
                    hit.transform.gameObject.gameObject.GetComponent<CorrectPoz>().ok = true;
            }
        }
    }
}
