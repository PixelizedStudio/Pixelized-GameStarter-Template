using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public string TargetTag;

    private Transform target;

    public float smoothSpeed;

    public Vector3 offset;

    

    void Update()
    {

        CameraFollow();

    }
    void CameraFollow()
    {
        target = GameObject.FindGameObjectWithTag(TargetTag).gameObject.transform;


        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

    }
    

    

    
}
