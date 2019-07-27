using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameScreenUIController : MonoBehaviour
{
    public static GameScreenUIController instance;

    public GameObject pausePopup;

    private float origTimeDelta = 0;
    private bool onPause = false;

    private void Awake ()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start ()
    {
        origTimeDelta = Time.timeScale;
    }

    public void OnPause ()
    {
        TogglePause ();
        pausePopup.SetActive (true);
    }

    public void TogglePause ()
    {
        if (!onPause) {
            Time.timeScale = 0.0f;
        } else {
            Time.timeScale = origTimeDelta;
        }
        onPause = !onPause;
    }

    public void OnResume ()
    {
        TogglePause ();
    }
}
