using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private float moveSpeed = 3f;
    private Vector2 moveInput;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        Move();
    }
    private void OnJump(InputValue value)
    {
        if(value.isPressed)
        {
            rb.AddForce((jumpForce * transform.up), ForceMode2D.Impulse);
        }
    }
    private void Move()
    {
        rb.velocity = transform.up * (moveInput.y * moveSpeed);
    }
    private void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

}


