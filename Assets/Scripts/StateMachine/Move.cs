using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : Ground
{
    public override void OnEnter()
    {
        base.OnEnter();
        
        Debug.Log("Move");
        _player.animator.Play("Move");
    }

    public override void OnExecute()
    {
        base.OnExecute();
        
        // _player.rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _player.speed, _player.rb.velocity.y);

        if (Input.GetAxisRaw("Horizontal") == 0)
        {
            _player.rb.velocity = Vector2.zero;
            _stateController.ChangeState(new Idle());
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
