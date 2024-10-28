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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _rb.AddForce(Vector2.up * _jumpForce, ForceMode2D.Impulse);
        }
    }
}
