using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody2D _rb;
    private Collider2D _col;
    
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private bool _isGrounded;
    [SerializeField] private LayerMask _jumpableLayers;

    [SerializeField] private float _gravityMultiplier = 1f;
    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _col = GetComponent<Collider2D>();
    }

    private void Start()
    {
        
    }
    
    private void Update()
    {
        //update speed
        _rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _speed, _rb.velocity.y);
        
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        if (Input.GetKeyDown(KeyCode.Space) && IsGrounded())
        {
            _rb.AddForce(Vector2.up * (_jumpForce * _gravityMultiplier), ForceMode2D.Impulse);
            //Debug.Log(Vector2.up * (_jumpForce * _gravityMultiplier));
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            ReverseGravity();
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.BoxCast(_col.bounds.center, _col.bounds.size, 0f, Vector2.down, 0.1f * _gravityMultiplier, _jumpableLayers);
    }
    
    private void ReverseGravity()
    {
        _gravityMultiplier *= -1;
        _rb.gravityScale *= -1;
    }
}
