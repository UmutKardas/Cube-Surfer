using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeCollisionController : MonoBehaviour
{
    [SerializeField] private MainCubeDataTransmitter mainCubeDataTransmitter;
    [SerializeField] private GameObject cubeControllerGameObject;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.tag = "ChildCube";
            transform.position = other.gameObject.transform.position;
            mainCubeDataTransmitter.SetMainCubeHeight();
            other.gameObject.transform.parent = cubeControllerGameObject.gameObject.transform;
        }
    }
}
