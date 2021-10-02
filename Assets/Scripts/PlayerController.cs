using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody rb;

    Vector2 move;

    private void Update()
    {
        Vector3 newVelocity = new Vector3(move.x, rb.velocity.y, move.y);
        rb.velocity = newVelocity;
    }

    void OnMove(InputValue val)
    {
        move = val.Get<Vector2>() * moveSpeed;
    }
}
