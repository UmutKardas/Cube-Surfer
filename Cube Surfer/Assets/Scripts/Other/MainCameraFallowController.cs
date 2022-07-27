using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraFallowController : MonoBehaviour
{
    [SerializeField] private Transform mainCubeTransform;
    [SerializeField] private float lerpValue;
    Vector3 offset;
    Vector3 newPosition;
    void Start()
    {
        offset = transform.position - mainCubeTransform.position;
    }

    void LateUpdate()
    {
        SetCameraFallow();
    }

    private void SetCameraFallow()
    {
        newPosition = Vector3.Slerp(transform.position,
        mainCubeTransform.position + offset,
        lerpValue);
        transform.position = new Vector3(transform.position.x, transform.position.y, newPosition.z);

    }
}
