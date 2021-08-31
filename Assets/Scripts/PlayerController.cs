using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float thrustMultiplier = 1;
    public float pitchMultiplier = 1;
    public float yawMultiplier = 1;
    public float rollMultiplier = 1;


    private float currThrust = 0;
    private float currPitch = 0;
    private float currYaw = 0;
    private float currRoll = 0;


    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        rb.AddForce(transform.forward * currThrust * thrustMultiplier, ForceMode.Force);
        rb.AddTorque(transform.right * currPitch * pitchMultiplier, ForceMode.Force);
        rb.AddTorque(transform.forward * currRoll * rollMultiplier, ForceMode.Force);
        rb.AddTorque(transform.up * currYaw * yawMultiplier, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void OnThrust(InputValue value)
    {
        currThrust = value.Get<float>();
    }

    void OnPitch(InputValue value)
    {
        currPitch = value.Get<float>();
    }

    void OnYaw(InputValue value)
    {
        currYaw = value.Get<float>();
    }

    void OnRoll(InputValue value)
    {
        Debug.Log("Roll");
        currRoll = value.Get<float>();
    }
}
