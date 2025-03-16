using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockCursorToCenter : MonoBehaviour

{
    void Update()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}

