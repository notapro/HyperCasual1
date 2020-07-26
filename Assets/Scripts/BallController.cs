using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private float force;
    [SerializeField] private bool doubleJump;
    
    private Rigidbody2D _rigidbody;
    
    private bool _addForce;
    private int _jumpCount;

    // Start is called before the first frame update
    void Start ()
    {
        _jumpCount = 0;
        _rigidbody = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void Update ()
    {
        if (JumpPossible() && Input.GetKeyDown (KeyCode.Space) || (Input.touchCount > 0 && Input.GetTouch (0).phase == TouchPhase.Began)) {
            Debug.Log("Space detected");
            _addForce = true;
            IncrementJumpCount();
        }
    }

    private void FixedUpdate()
    {
        if (_addForce) {
            _addForce = false;
            _rigidbody.AddForce (new Vector2 (0.0f, force));
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        ResetJumpCount();
    }

    private bool JumpPossible()
    {
        if (_jumpCount == 0 || (doubleJump && _jumpCount < 2))
        {
            return true;
        }

        return false;
    }

    private void IncrementJumpCount()
    {
        _jumpCount++;
    }

    private void ResetJumpCount()
    {
        _jumpCount = 0;
    }
}
