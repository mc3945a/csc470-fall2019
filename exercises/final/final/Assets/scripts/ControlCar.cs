using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCar : MonoBehaviour
{
    public float MotorForce, SteerForce, BrakeForce, SlowDownForce;
    public float maxSpeed = 100f;

    private Rigidbody rb;
    private Transform thisTransform;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        thisTransform = this.transform;
    }

    void Update()
    {
        bool isBraking = Input.GetKey(KeyCode.Space);
        float v = 0f;
        float h = Input.GetAxis("Horizontal") * SteerForce;
        thisTransform.Rotate(new Vector3(0f, h, 0f));

        if (!isBraking && rb.velocity.magnitude < maxSpeed)
        {
            v = Input.GetAxis("Vertical") * MotorForce;
            rb.AddForce(thisTransform.forward * v);
        }
        
        if(rb.velocity.magnitude > maxSpeed)
        {
            rb.velocity = rb.velocity.normalized * maxSpeed;
        }

        //Debug.Log("Speed: " + rb.velocity.magnitude);

        if(isBraking) //pressing brakes
        {
            rb.drag = BrakeForce;
        }
        else if(v == 0f) //not pressing gas nor brakes
        {
            rb.drag = SlowDownForce;
        }
        else //pressing gas
        {
            rb.drag = 0f;
        }
    }
}
