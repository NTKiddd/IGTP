using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private StateController _stateController;
    
    [HideInInspector] public Rigidbody2D rb;
    [HideInInspector] public Collider2D col;
    [HideInInspector] public Animator animator;
    
    public float speed;
    public float jumpForce;
    public bool isGrounded;
    public LayerMask jumpableLayers;
    public LayerMask climbableLayers;
    
    public int gravityMultiplier = 1;
    public float facingDirection = 1f;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
        animator = GetComponent<Animator>();
    }

    private void Start()
    {
        
    }
    
    private void Update()
    {
        // //update speed
        // _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed, _rb.velocity.y);
        //
        // //Debug.Log(Input.GetAxisRaw("Horizontal"));
        // if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        // {
        //     _rb.AddForce(Vector2.up * (jumpForce * gravityMultiplier), ForceMode2D.Impulse);
        //     //Debug.Log(Vector2.up * (_jumpForce * _gravityMultiplier));
        // }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ReverseGravity();
        }
    }

    public bool IsGrounded()
    {
        return Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0f, Vector2.down, 0.15f * gravityMultiplier, jumpableLayers);
    }
    
    public bool IsClimbable()
    {
        return Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0f, Vector2.zero, 0f, climbableLayers);
    }
    
    private void ReverseGravity()
    {
        gravityMultiplier *= -1;
        rb.gravityScale *= -1;
    }
    
    public void Flip()
    {
        facingDirection *= -1;
        transform.localScale = new Vector3(facingDirection, transform.localScale.y);
    }
}
