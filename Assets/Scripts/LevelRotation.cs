using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRotation : MonoBehaviour
{
    private float torque = 1;

    // Start is called before the first frame update
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {
        transform.Rotate (0, 0, torque);
    }

    public void FlipRotation ()
    {
        torque = -1 * torque;
    }
}
