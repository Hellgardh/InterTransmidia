using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public bool smooth;

    private float smoothSpeed = 0.125f;

    public Vector3 offsetPos;
    public Vector3 offsetRotation;

    private void LateUpdate ()
    {
        Vector3 desiredPos = target.transform.position + offsetPos;

        if(smooth)
        {
            transform.position = Vector3.Lerp(transform.position, desiredPos, smoothSpeed);
            transform.rotation = Quaternion.Euler(Vector3.Lerp(transform.rotation.eulerAngles, offsetRotation, smoothSpeed));
        }

        else
        {
            transform.position = desiredPos;
        }
    }
}
