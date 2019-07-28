using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishRegion : MonoBehaviour
{
    private void OnTriggerEnter2D (Collider2D collision)
    {
        GameScreenUIController.instance.PuzzleComplete ();
    }
}
