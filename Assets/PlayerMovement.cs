using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce = 2000f;

    public float sidewayForce = 500f;

    bool moveLeft = false;

    bool moveRight = false;

    // This is a reference to the Rightbody component called rb
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
    }

    void Update() {
        moveRight = false;
        moveLeft = false;
        if(Input.GetKey("d")) {
            moveRight = true;
        }
        if (Input.GetKey("a")) {
            moveLeft = true;
        }
    }

    // FixedUpdate is called once per frame and it is named this
    // way because we are dealing with physics
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce * Time.deltaTime);

        if(moveRight) {
            rb.AddForce(sidewayForce, 0, 0);
        }
        if (moveLeft) {
            rb.AddForce(-sidewayForce, 0, 0);
        }
    }
}
