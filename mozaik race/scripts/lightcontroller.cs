using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightcontroller : MonoBehaviour
{

    public Transform target;

    void FixedUpdate()
    {
        Vector3 newPosition = target.position;
        newPosition.z = 5;

        transform.position = newPosition;
    }
}
