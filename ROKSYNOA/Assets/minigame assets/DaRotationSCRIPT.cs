using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DaRotationSCRIPT : MonoBehaviour
{
    public int cnt = 0;
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        Quaternion rot;
        float x, y, z;
       
        
        rot = new Quaternion(90f, 0f, 0f, 0f);
        if (Input.GetMouseButtonDown(0))
        {
        
            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Selectable"&&hit.transform.gameObject.GetComponent<CorrectPoz>().ok==false)
            {
                Debug.Log("lalala");
                x = hit.transform.gameObject.GetComponent<CorrectPoz>().x;
                y=hit.transform.gameObject.GetComponent<CorrectPoz>().y;
                z=hit.transform.gameObject.GetComponent<CorrectPoz>().z;

                hit.transform.gameObject.transform.Rotate(0,45,0);
                Debug.Log(hit.transform.gameObject.transform.rotation.x);
                if (hit.transform.gameObject.transform.rotation == Quaternion.Euler(x, y, z))
                {
                    hit.transform.gameObject.gameObject.GetComponent<CorrectPoz>().ok = true;
                    cnt++;
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {

            if (Physics.Raycast(ray, out hit) && hit.transform.gameObject.tag == "Selectable" && hit.transform.gameObject.GetComponent<CorrectPoz>().ok == false)
            {
                Debug.Log("lalala");

                x = hit.transform.gameObject.GetComponent<CorrectPoz>().x;
                y = hit.transform.gameObject.GetComponent<CorrectPoz>().y;
                z = hit.transform.gameObject.GetComponent<CorrectPoz>().z;
                hit.transform.gameObject.transform.Rotate(0, -45, 0);
                Debug.Log(hit.transform.gameObject.transform.rotation.x);
                if (hit.transform.gameObject.transform.rotation == Quaternion.Euler(x, y, z))
                {
                    hit.transform.gameObject.gameObject.GetComponent<CorrectPoz>().ok = true;
                    cnt++;
                }
            }
        }
        if(cnt==5)
            SceneManager.LoadScene("roxnoa game");
    }
}
