using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VehicleCam : MonoBehaviour
{
    public Transform pivot;

    void FixedUpdate()
    {
        Vector3 origin =  pivot.transform.position;
        Vector3 direction = transform.position - pivot.transform.position;

        float maxCameraDistance = 10;

        Ray ray = new Ray(origin, direction);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, maxCameraDistance))
        {
            Vector3 offsetFromObstacle = -direction.normalized * 0.1f;
            transform.position = hit.point + offsetFromObstacle;
        }
    }
}