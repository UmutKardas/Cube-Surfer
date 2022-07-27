using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeMovementController : MonoBehaviour
{
    [SerializeField] private MainCubeDataTransmitter mainCubeDataTransmitter;
    [SerializeField] private float mainCubeSpeed;
    [SerializeField] private float mainCubeSpeedX;
    [SerializeField] private float mainCubeLimitX;
    private float mainCubeNewX;
    private Vector3 newMainCubeVec;



    void Update()
    {
        SetMainCubeMovement();
        SetMainCubeX();
    }

    private void SetMainCubeX()
    {
        mainCubeNewX = transform.position.x + mainCubeSpeedX
        * mainCubeDataTransmitter.GetMainCubeMouseX()
        * Time.deltaTime;
        mainCubeNewX = Mathf.Clamp(mainCubeNewX, -mainCubeLimitX, mainCubeLimitX);
    }

    private void SetMainCubeMovement()
    {
        newMainCubeVec = new Vector3(mainCubeNewX,
        transform.position.y,
        transform.position.z + mainCubeSpeed * Time.deltaTime);
        transform.position = newMainCubeVec;
    }


}
