using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class RotationHelper
{
    [Header("Rotation")]
    private const float rotationSpeed = 10F;
    public static float RotationSpeed { get => rotationSpeed; }
    public static float RotationFrame { get => RotationSpeed * Time.deltaTime; }

    public static void RotateTo(GameObject gameObject, Vector3 position)
    {
        Vector3 myPos = gameObject.transform.position;
        if (myPos == position) return;

        Vector3 myDir = gameObject.transform.forward;
        Vector3 direction = (position - myPos).normalized;
        RotateAt(gameObject, direction);

        float angle = Vector3.Angle(myDir, direction);
        float allowedAngle = RotationFrame;
        //if (Vector3.Angle(myDir, direction) >= 0.1F)
        if (angle > allowedAngle)
        {
            direction = Vector3.Lerp(myDir, direction, allowedAngle);
        }
        gameObject.transform.forward = direction;
    }

    public static void RotateAt(GameObject gameObject, Vector3 direction)
    {
        if (direction.magnitude <= 0F) return;
        Vector3 myDir = gameObject.transform.forward;

        float angle = Vector3.Angle(myDir, direction);
        float allowedAngle = RotationFrame;
        //if (Vector3.Angle(myDir, direction) >= 0.1F)
        //if (angle > 5F && angle > allowedAngle)
        //if (angle != 0 && angle > allowedAngle)
        if (angle > allowedAngle)
        {
            direction = Vector3.Lerp(myDir, direction, RotationFrame);
        }
        gameObject.transform.forward = direction;
    }
}
