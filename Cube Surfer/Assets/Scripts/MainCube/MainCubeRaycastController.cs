using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeRaycastController : MonoBehaviour
{
    [SerializeField] private MainCubeDataTransmitter mainCubeDataTransmitter;
    [SerializeField] private LayerMask layer;

    private float maxDistance = 0.5f;
    RaycastHit hit;

    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, layer);
        if (hit.collider != null)
        {
            mainCubeDataTransmitter.SetMainCubeDead();

        }

    }

}
