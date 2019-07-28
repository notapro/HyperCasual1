using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    private float torque = 1;

    void FixedUpdate ()
    {
        transform.Rotate (0, 0, torque);
    }

    public void FlipRotation ()
    {
        torque = -1 * torque;
    }
}
