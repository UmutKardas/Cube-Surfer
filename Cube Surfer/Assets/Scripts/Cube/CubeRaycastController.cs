using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRaycastController : MonoBehaviour
{
    [SerializeField] private LayerMask layer;
    [SerializeField] private GameObject BlockCubeGameObject;
    private float maxDistance = 0.3f;
    RaycastHit hit;

    void Update()
    {
        Physics.Raycast(transform.position, transform.forward, out hit, maxDistance, layer);
        if (hit.collider != null)
        {
            transform.parent = BlockCubeGameObject.transform;
        }

    }

}
