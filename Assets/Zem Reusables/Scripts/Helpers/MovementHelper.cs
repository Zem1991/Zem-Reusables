using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class MovementHelper
{
    [Header("Movement")]
    private const float movementSpeed = 5F;
    public static float MovementSpeed { get => movementSpeed; }
    public static float MovementFrame { get => MovementSpeed * Time.deltaTime; }

    public static void MoveTo(GameObject gameObject, Vector3 position)
    {
        Vector3 myPos = gameObject.transform.position;
        if (myPos == position) return;

        float distance = Vector3.Distance(myPos, position);
        float allowedDistance = MovementFrame;
        if (distance > allowedDistance)
        {
            Vector3 direction = (position - myPos).normalized;
            MoveAt(gameObject, direction);
            //Vector3 positionDelta = direction * allowedDistance;
            //transform.position += positionDelta;
        }
        else
        {
            gameObject.transform.position = position;
        }
    }

    public static void MoveAt(GameObject gameObject, Vector3 direction)
    {
        if (direction.magnitude <= 0F) return;
        Vector3 positionDelta = direction * MovementFrame;
        gameObject.transform.position += positionDelta;
    }
}
