using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    bool rotating;
    float rotateSpeed = 0.5f;
    float fixAngle = 30.0f;
    Vector3 mousePos, offset, rotation;

    void OnMouseDown()
    {
        rotating = true;

        mousePos = Input.mousePosition;
    }

    void OnMouseUp()
    {
        rotating = false;

        float xAngle = ((int)this.transform.localEulerAngles.z / (int)fixAngle) * fixAngle;
        Vector3 localEulerAngles = this.transform.localEulerAngles;

        localEulerAngles.z = xAngle;
        this.transform.localEulerAngles = localEulerAngles;
    }

    void Update()
    {
        if (rotating)
        {
            offset = (Input.mousePosition - mousePos);

            rotation.z = -(offset.x + offset.z) * rotateSpeed;

            transform.Rotate(rotation);

            mousePos = Input.mousePosition;
        }
    }
}