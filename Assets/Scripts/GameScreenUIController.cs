using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreenUIController : MonoBehaviour
{
    public static GameScreenUIController instance;

    public GameObject pausePopup;
    public GameObject puzzleCompletePopup;
    public GameObject puzzleContainer;

    private float origTimeDelta = 0;
    private bool onPause = false;

    private void Awake ()
    {
        instance = this;
        origTimeDelta = Time.timeScale;
    }

    private void OnEnable ()
    {
        TogglePuzzle (true);
    }

    public void OnPause ()
    {
        TogglePause (true);
        pausePopup.SetActive (true);
    }

    public void PuzzleComplete ()
    {
        TogglePause (true);
        puzzleCompletePopup.SetActive (true);
    }

    public void TogglePause (bool pause)
    {
        if (pause) {
            Time.timeScale = 0.0f;
        } else {
            Time.timeScale = origTimeDelta;
        }
        onPause = pause;
    }

    public void OnResume ()
    {
        TogglePause (false);
    }

    public void TogglePuzzle (bool show)
    {
        puzzleContainer.SetActive (show);
    }

    public void ExitPuzzle ()
    {
        TogglePuzzle (false);
        ShowHomeScreen ();
        Hide ();
    }

    public void ShowHomeScreen ()
    {
        ScreenController.instance.ShowHomeScreen ();
    }

    public void Hide ()
    {
        gameObject.SetActive (false);
    }
}
