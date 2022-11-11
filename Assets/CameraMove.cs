﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    public float Sensitivity;
    public bool ShowCursor = false;


    void Start()
    {
        if (ShowCursor == false)
        {
            Cursor.visible = false;
        }
    }


    void Update()
    {
        float newRotationY = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * Sensitivity;

        gameObject.transform.localEulerAngles = new Vector3(0, newRotationY, 0);
    }
}
