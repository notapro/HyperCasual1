using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenController : MonoBehaviour
{
    public static ScreenController instance;

    public GameObject homeScreen;
    public GameObject puzzleScreen;

    void Awake ()
    {
        instance = this;
    }

    public void ShowPuzzleScreen ()
    {
        puzzleScreen.SetActive (true);
    }

    public void ShowHomeScreen ()
    {
        homeScreen.SetActive (true);
    }

}
