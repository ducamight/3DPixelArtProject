using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDownObject : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float maxHeight = 2.5f;
    public float minHeight = -1.5f;

    private bool movingUp = true;

    void Update()
    {
        // Move the object up and down along the Y-axis
        if (movingUp)
        {
            transform.Translate(Vector3.up * moveSpeed * Time.deltaTime);
            if (transform.position.y >= maxHeight)
                movingUp = false;
        }
        else
        {
            transform.Translate(Vector3.down * moveSpeed * Time.deltaTime);
            if (transform.position.y <= minHeight)
                movingUp = true;
        }
    }
}
