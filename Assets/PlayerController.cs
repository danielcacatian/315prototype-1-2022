using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public float gravity;
    private Rigidbody myRigidbody;

    private Vector3 moveInput;
    private Vector3 moveVelocity;

    // Use this for initialization
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        // Player input/movement on the X and Z axis
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0f, Input.GetAxis("Vertical"));
        moveVelocity = moveInput * moveSpeed;

        // Jump
        if (Input.GetButton("Jump"))
        {
            moveInput.y = moveSpeed;
        }

        // Gravity
        moveInput.y -= gravity * Time.deltaTime;

    }

    private void FixedUpdate()
    {
        myRigidbody.velocity = moveVelocity;
    }
}
