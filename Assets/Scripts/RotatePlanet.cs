using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePlanet : MonoBehaviour
{
    public float rotationSpeed = 30f;
    void Update()
    {
        float rotationAmount = rotationSpeed * Time.deltaTime;

        transform.Rotate(0, rotationAmount, 0);
    }
}
