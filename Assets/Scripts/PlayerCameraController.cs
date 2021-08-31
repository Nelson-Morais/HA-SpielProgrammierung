using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraController : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;

    [Range(0,1)]
    public float smoothSpeed;

    private void FixedUpdate()
    {
        transform.position = Vector3.Lerp(target.position + target.TransformDirection(offset), transform.position,smoothSpeed);
        transform.LookAt(target.position, target.up);
    }
}
