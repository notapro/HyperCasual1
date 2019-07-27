using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float force;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start ()
    {
        rb = GetComponent<Rigidbody2D> ();
    }

    // Update is called once per frame
    void FixedUpdate ()
    {
        if (Input.GetKeyDown (KeyCode.Space)) {
            rb.AddForce (new Vector2 (0.0f, force));
        }
    }
}
