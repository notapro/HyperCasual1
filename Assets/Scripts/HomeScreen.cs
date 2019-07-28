using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeScreen : MonoBehaviour
{
    public void Play ()
    {
        Hide ();
        ScreenController.instance.ShowPuzzleScreen ();
    }

    public void Hide ()
    {
        gameObject.SetActive (false);
    }
}
