using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PausePopup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start ()
    {

    }

    // Update is called once per frame
    void Update ()
    {

    }

    public void Resume ()
    {
        GameScreenUIController.instance.TogglePause ();
        Hide ();
    }

    public void Exit ()
    {

    }

    public void Hide ()
    {
        gameObject.SetActive (false);
    }
}
