using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 100f;
    public float rotationSpeed = 4f;
    public Rigidbody rb;
    public Transform cameraTransform;

    Vector2 movement;
    Vector3 move;

    private void Update()
    {
        //Changes velocity of X and Z to move value but keeps y value the same
        move = new Vector3(movement.x, 0f, movement.y);
        move = cameraTransform.forward * move.z + cameraTransform.right * move.x;
        rb.velocity = (move * moveSpeed).Y(rb.velocity.y);

        //Rotates the player to the direction of movement
        if (movement != Vector2.zero)
        {
            float targetAngle = Mathf.Atan2(movement.x, movement.y) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            Quaternion rotation = Quaternion.Euler(0f, targetAngle, 0f);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, Time.deltaTime * rotationSpeed);
        }
    }

    void OnMove(InputValue val)
    {
        movement = val.Get<Vector2>();
    }

    void OnJump(InputValue val)
    {
        Vector3 jumpVelocity = new Vector3(0, jumpForce, 0);
        rb.AddForce(jumpVelocity);
    }
}
