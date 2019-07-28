using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleComplete : MonoBehaviour
{
    public void Next ()
    {

    }

    public void Exit ()
    {
        Hide ();
        GameScreenUIController.instance.ExitPuzzle ();
    }

    public void Hide ()
    {
        gameObject.SetActive (false);
    }
}
