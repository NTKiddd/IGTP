using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Air
{
    public override void OnEnter()
    {
        base.OnEnter();
        
        Debug.Log("Jump");
        _player.rb.velocity = Vector2.zero;
        _player.rb.AddForce(Vector2.up * (_player.jumpForce * _player.gravityMultiplier), ForceMode2D.Impulse);
        _player.animator.Play("Jump");
    }

    public override void OnExecute()
    {
        base.OnExecute();
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
