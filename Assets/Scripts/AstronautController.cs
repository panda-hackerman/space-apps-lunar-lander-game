using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AstronautController : MonoBehaviour
{
    public float jumpForce = 250f;
    public float rotationSpeed = 2f;
    public Rigidbody rb;
    public Collider astronautCollider;

    private float groundDistance;
    private Vector2 movement;

    bool isGrounded()
    {
        // cast from position to 0.1 units under the player
        return Physics.Raycast(transform.position, -Vector3.up, groundDistance + 0.1f);
    }

    private void Start()
    {
        // ground distance is the bottom of the players collider
        groundDistance = astronautCollider.bounds.extents.y;
    }

    private void Update()
    {
        if (movement != Vector2.zero)
        {
            if (movement.y > 0) transform.Rotate(rotationSpeed, 0, 0);
            if (movement.y < 0) transform.Rotate(-rotationSpeed, 0, 0);
            if (movement.x > 0) transform.Rotate(0, 0, -rotationSpeed);
            if (movement.x < 0) transform.Rotate(0, 0, rotationSpeed);
        }
    }

    void OnMove(InputValue val)
    {
        movement = val.Get<Vector2>();
    }

    void OnJump(InputValue val)
    {
        if (isGrounded())
        {
            // adds immediate force to the current upward direction of the player
            rb.AddForce(transform.up * (jumpForce * Time.deltaTime), ForceMode.Impulse);
        }
    }
}
