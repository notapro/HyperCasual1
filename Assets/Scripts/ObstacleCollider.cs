using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleCollider : MonoBehaviour
{
    private void OnCollisionEnter2D (Collision2D collision)
    {
        transform.parent.parent.GetComponent<LevelRotation> ().FlipRotation ();
    }
}
