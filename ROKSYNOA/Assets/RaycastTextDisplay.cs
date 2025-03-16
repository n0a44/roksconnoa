using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RaycastTextDisplay : MonoBehaviour
{
    [SerializeField] private GameObject leftClickText;
    

    void Start()
    {
        leftClickText.SetActive(false);
    }

    void OnMouseEnter()
    {
        leftClickText.SetActive(true);
    }

    void OnMouseExit()
    {
        leftClickText.SetActive(false);
    }

}
