using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPivot : MonoBehaviour
{
    [SerializeField] private float targetAngle = 45f;
    [SerializeField] private float currentAngle = 0f;
    [SerializeField] public float mouseSensitivity = 45f;
    [SerializeField] private float rotationSpeed = 45f;

    private void Update() {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if(Input.GetMouseButton(0)){
            targetAngle += mouseX * mouseSensitivity;
        }

        else{
            targetAngle = Mathf.Round(targetAngle/45);
        }

        if(targetAngle<0){
            targetAngle+=360;
        }
        if(targetAngle>360){
            targetAngle-=360;
        }

        currentAngle = Mathf.LerpAngle(transform.eulerAngles.y, targetAngle, rotationSpeed* Time.deltaTime);
        transform.rotation = Quaternion.Euler(30, currentAngle, 0);
    }
}
