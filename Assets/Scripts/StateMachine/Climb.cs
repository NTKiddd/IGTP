using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Climb : State
{
    private float _originalGravityScale;
    
    public override void OnInitialize()
    {
        base.OnInitialize();
    }

    public override void OnEnter()
    {
        base.OnEnter();
        
        Debug.Log("Fall");
        _originalGravityScale = _player.rb.gravityScale;
        _player.rb.gravityScale = 0f;
    }

    public override void OnExecute()
    {
        base.OnExecute();
        
        if (Input.GetAxisRaw("Vertical") != 0)
        {
            _player.rb.velocity = new Vector2(_player.rb.velocity.x, Input.GetAxisRaw("Vertical") * 5);
        }
        else
        {
            _player.rb.velocity = new Vector2(_player.rb.velocity.x, 0);
        }
        
        if (!_player.IsClimbable())
        {
            _stateController.ChangeState(new Fall());
        }
    }

    public override void OnExit()
    {
        base.OnExit();
        
        _player.rb.gravityScale = _originalGravityScale;
    }
}
