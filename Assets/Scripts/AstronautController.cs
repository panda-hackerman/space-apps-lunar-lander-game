using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AstronautController : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 250f;
    public float rotationSpeed = 2f;
    public Rigidbody rb;
    public Collider astronautCollider;

    private bool fallMode;
    private float groundDistance;
    private Vector2 movement;
    private Vector3 move;
    public Transform pivot;
    public Transform cameraTransform;

    private float getUpTimer = 2;
    private float getUpTime;

    bool isGrounded()
    {
        // cast from position to 0.1 units under the player
        return Physics.Raycast(transform.position, -Vector3.up, groundDistance + 0.1f);
    }

    private void Start()
    {
        // ground distance is the bottom of the players collider
        groundDistance = astronautCollider.bounds.extents.y;
        getUpTime = getUpTimer;
        fallMode = false;
    }

    private void Update()
    {
        if (fallMode)
        {
            rb.freezeRotation = false;

            if (movement != Vector2.zero)
            {
                if (isGrounded())
                {
                    if (movement.y > 0) transform.RotateAround(pivot.position, cameraTransform.right, rotationSpeed * Time.deltaTime);
                    if (movement.y < 0) transform.RotateAround(pivot.position, -cameraTransform.right, rotationSpeed * Time.deltaTime);
                    if (movement.x > 0) transform.RotateAround(pivot.position, -cameraTransform.forward, rotationSpeed * Time.deltaTime);
                    if (movement.x < 0) transform.RotateAround(pivot.position, cameraTransform.forward, rotationSpeed * Time.deltaTime);
                }
                else
                {
                    if (movement.y > 0) transform.RotateAround(transform.position, cameraTransform.right, rotationSpeed * Time.deltaTime);
                    if (movement.y < 0) transform.RotateAround(transform.position, -cameraTransform.right, rotationSpeed * Time.deltaTime);
                    if (movement.x > 0) transform.RotateAround(transform.position, -cameraTransform.forward, rotationSpeed * Time.deltaTime);
                    if (movement.x < 0) transform.RotateAround(transform.position, cameraTransform.forward, rotationSpeed * Time.deltaTime);
                }
            }
            if (isGrounded())
            {
                if (getUpTime <= 0)
                {
                    getUpTime = getUpTimer;
                    fallMode = false;
                    transform.rotation = Quaternion.identity;
                }
                else getUpTime -= Time.deltaTime;
            }
        }
        else
        {
            rb.freezeRotation = true;

            if (isGrounded())
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
            fallMode = true;

            Vector3 jumpDir = transform.up + new Vector3(0, 1, 0) + cameraTransform.forward * 2;

            // adds immediate force to the current upward direction of the player
            rb.AddForce(jumpDir * (jumpForce * Time.deltaTime), ForceMode.Impulse);
        }
    }
}
