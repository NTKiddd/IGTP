using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : Air
{
    public override void OnInitialize()
    {
        base.OnInitialize();
    }

    public override void OnEnter()
    {
        base.OnEnter();
        
        Debug.Log("Fall");
        _player.animator.Play("Fall");
    }

    public override void OnExecute()
    {
        base.OnExecute();
        
        if (_player.IsGrounded())
        {
            Debug.Log("grounded");
            _stateController.ChangeState(new Idle());
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
