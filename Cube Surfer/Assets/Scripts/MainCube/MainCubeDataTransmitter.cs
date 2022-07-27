using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeDataTransmitter : MonoBehaviour
{
    [SerializeField] private MainCubeInputController mainCubeInputController;
    [SerializeField] private MainCubeHeightController mainCubeHeightController;
    [SerializeField] private MainCubeDeadController mainCubeDeadController;

    public float GetMainCubeMouseX()
    {
        return mainCubeInputController.mouseX;
    }
    public void SetMainCubeHeight()
    {
        mainCubeHeightController.SetMainCubeHeight();
    }
    public void SetMainCubeDead()
    {
        mainCubeDeadController.SetMainCubeDead();
    }


}
