using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float movementSpeed;
    public float strafeSpeed;
    public float rotationSpeed;
    public float mouseLookSensitivityX = 1.0f;
    public float mouseLookSensitivityY = 1.0f;
    public float jumpForce;

    void Update () {
        if(Input.GetAxis("Vertical") != 0f)
        {
            Move(Input.GetAxis("Vertical") * movementSpeed);
        }

        if (Input.GetAxis("Horizontal") != 0f)
        {
            Strafe(Input.GetAxis("Horizontal") * strafeSpeed);
        }

        if (Input.GetAxis("Mouse Y") != 0f)
        {
            Rotate(Input.GetAxis("Mouse X") * rotationSpeed);
        }

        if (Input.GetAxis("Mouse X") != 0f)
        {
            Rotate(Input.GetAxis("Mouse X") * rotationSpeed * mouseLookSensitivityX);
        }

        if (Input.GetAxis("Mouse Y") != 0f)
        {
            Look(Input.GetAxis("Mouse Y") * mouseLookSensitivityX * -1f);
        }

        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    private void Move(float movement)
    {
        transform.Translate(0, 0, movement * Time.deltaTime);
    }

    private void Rotate(float rotation)
    {
        transform.Rotate(0, rotation * Time.deltaTime, 0);
    }

    private void Look(float lookAmount)
    {
        gameObject.GetComponentInChildren<Camera>().transform.Rotate(lookAmount, 0, 0);
    }

    private void Strafe(float strafeMovement)
    {
        transform.Translate(strafeMovement * Time.deltaTime, 0, 0);
    }

    private void Jump()
    {
        Rigidbody rb = gameObject.GetComponent<Rigidbody>();

        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
}
