using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rightbody component called rb
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // FixedUpdate is called once per frame and it is named this
    // way because we are dealing with physics
    void FixedUpdate()
    {
        rb.AddForce(0,0,2000 * Time.deltaTime);
    }
}
