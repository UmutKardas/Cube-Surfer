using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeHeightController : MonoBehaviour
{

    public void SetMainCubeHeight()
    {
        transform.position = new Vector3(transform.position.x,
        transform.position.y + 1f, transform.position.z);
    }
}
