using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMovement : MonoBehaviour
{
    public float scale = 0.3f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.up * Platform_Movement.ySpeed * Time.fixedDeltaTime*scale);
    }
}
