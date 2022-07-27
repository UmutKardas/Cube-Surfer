using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeInputController : MonoBehaviour
{
    public float mouseX;
    void Update()
    {
        SetMouseXTouch();
    }

    private void SetMouseXTouch()
    {
        if (Input.GetMouseButton(0))
        {
            mouseX = Input.GetAxis("Mouse X");
        }
        else
        {
            mouseX = 0;
        }
    }

}
