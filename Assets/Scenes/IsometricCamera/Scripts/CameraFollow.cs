using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Người chơi hoặc đối tượng cần theo dõi
    public float smoothSpeed = 0.125f; // Tốc độ di chuyển mượt của camera
    public Vector3 offset; // Khoảng cách giữa camera và người chơi

    void LateUpdate()
    {
        if (target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
            transform.position = smoothedPosition;
            transform.LookAt(target);
        }
    }
}
