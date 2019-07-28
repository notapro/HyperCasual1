﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePopup : MonoBehaviour
{
    public void Resume ()
    {
        GameScreenUIController.instance.TogglePause (false);
        Hide ();
    }

    public void Exit ()
    {
        GameScreenUIController.instance.ExitPuzzle ();
    }

    public void Hide ()
    {
        gameObject.SetActive (false);
    }
}
