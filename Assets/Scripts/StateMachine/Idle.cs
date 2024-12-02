using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Idle : Ground
{
    public override void OnInitialize()
    {
        
    }
    
    public override void OnEnter()
    {
        base.OnEnter();
        
        Debug.Log("Idle");
        _player.rb.velocity = Vector2.zero;
        _player.animator.Play("Idle");
    }

    public override void OnExecute()
    {
        base.OnExecute();
        
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            _stateController.ChangeState(new Move());
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
