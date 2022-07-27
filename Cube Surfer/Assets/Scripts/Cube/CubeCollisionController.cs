using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionController : MonoBehaviour
{
    [SerializeField] private MainCubeDataTransmitter mainCubeDataTransmitter;
    [SerializeField] private GameObject cubeControllerGameObject;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Cube"))
        {
            other.gameObject.tag = "ChildCube";
            other.transform.position = new Vector3(transform.position.x,
            other.transform.position.y, transform.position.z);
            mainCubeDataTransmitter.SetMainCubeHeight();
            other.gameObject.transform.parent = cubeControllerGameObject.gameObject.transform;
        }
    }
}
