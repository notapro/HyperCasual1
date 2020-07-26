using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScreenUIController : MonoBehaviour
{
    public static GameScreenUIController instance;

    [SerializeField] private GameObject pausePopup;
    [SerializeField] private GameObject puzzleCompletePopup;
    [SerializeField] private GameObject puzzleContainer;
    [SerializeField] private GameObject timer;

    [SerializeField] private int puzzleDuration;
    
    private float _origTimeDelta = 0;
    private bool _onPause = false;

    private void Awake ()
    {
        instance = this;
        _origTimeDelta = Time.timeScale;
    }

    private void OnEnable ()
    {
        TogglePuzzle (true);
        timer.GetComponent<Timer>().Init(puzzleDuration, PuzzleComplete);
    }

    public void OnPause ()
    {
        TogglePause (true);
        timer.GetComponent<Timer>().PauseTimer();
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
            Time.timeScale = _origTimeDelta;
        }
        _onPause = pause;
    }

    public void OnResume ()
    {
        TogglePause (false);
        timer.GetComponent<Timer>().ResumeTimer();
    }

    public void TogglePuzzle (bool show)
    {
        puzzleContainer.SetActive (show);
        timer.SetActive(true);
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
