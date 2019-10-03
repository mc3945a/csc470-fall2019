using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanePilot : MonoBehaviour
{
    public float maxForwardSpeed = 30f;
    public float acceleration = 5f;
    public float decceleration = 10f;

    private float currentVelocity;
    private Rigidbody rb;


    void Start()
    {
        Debug.Log("plane pilot scipt added to:" + gameObject.name);
        rb = GetComponent<Rigidbody>();
    }


    void Update()
    {
        /*Vector3 moveCamTo = transform.position - transform.forward * 10.0f + Vector3.up * 5.0f;
        float bias = 0.96f;
        Camera.main.transform.position = Camera.main.transform.position * bias + moveCamTo * (1.0f-bias);
        Camera.main.transform.LookAt(transform.position - transform.forward * 30.0f); */

        if (Input.GetKey(KeyCode.Space))
        {
            if (currentVelocity < maxForwardSpeed)
            {
                currentVelocity += Time.deltaTime * acceleration;
            }
            else
            {
                currentVelocity = maxForwardSpeed;
            }
            rb.AddForce(transform.forward * -currentVelocity);
        }
        else
        {
            if (rb.velocity.z <= 0)
            {
                rb.velocity = Vector3.zero;
            }
            else
            {
                rb.AddForce(-transform.forward * decceleration * Time.deltaTime);
            }
        }

        transform.Rotate(Input.GetAxis("Vertical"), Input.GetAxis("Horizontal"), 0.0f);


    }

}
