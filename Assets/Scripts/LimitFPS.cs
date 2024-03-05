using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    public int targetFPS = 60;

    void Start()
    {
        Application.targetFrameRate = targetFPS;
    }
}
