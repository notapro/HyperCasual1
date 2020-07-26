using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float force;
    private bool addForce;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start ()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update ()
    {
        if (Input.GetKeyDown (KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)) {
            Debug.Log("Space detected");
            addForce = true;
        }
    }

    private void FixedUpdate()
    {
        if (addForce) {
            addForce = false;
            rb.AddForce (new Vector2 (0.0f, force));
        }
    }
}
