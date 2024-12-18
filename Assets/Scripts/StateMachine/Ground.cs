using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : State
{
    public override void OnInitialize()
    {
        base.OnInitialize();
    }

    public override void OnEnter()
    {
        base.OnEnter();
    }

    public override void OnExecute()
    {
        base.OnExecute();
        
        if (!_player.IsGrounded() && _player.rb.velocity.y < 0)
        {
            _stateController.ChangeState(new Fall());
        }
        
        if (!_player.IsGrounded() && _player.rb.velocity.y > 0 && _player.gravityMultiplier == -1)
        {
            _stateController.ChangeState(new Fall());
        }

        if (Input.GetKeyDown(KeyCode.Space) && _player.IsGrounded())
        {
            _stateController.ChangeState(new Jump());
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
