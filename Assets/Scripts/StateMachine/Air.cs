using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Air : State
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
        
        if (_player.rb.velocity.y <= 0)
        {
            _stateController.ChangeState(new Fall());
        }
    }

    public override void OnExit()
    {
        base.OnExit();
    }
}
