using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] Vector3 offset;
    [SerializeField] private float speed = 0.125f;
    // Start is called before the first frame update
    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, speed);
        transform.position = smoothedPosition;
        transform.LookAt(target);
    }
}
