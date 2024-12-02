using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    protected Player _player;
    protected StateController _stateController;

    public void Initialize(StateController stateController, Player player)
    {
        _stateController = stateController;
        _player = player;
        OnInitialize();
        
        OnEnter();
    }
    
    public virtual void OnInitialize()
    {
        
    }

    public virtual void OnEnter()
    {
        
    }
    
    public virtual void OnExecute()
    {
        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            _player.rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * _player.speed, _player.rb.velocity.y);
            
            if ((_player.rb.velocity.x < 0.5f && _player.facingDirection > 0) || (_player.rb.velocity.x > 0.5f && _player.facingDirection < 0))
            {
                _player.Flip();
            }
        }
        else
        {
            _player.rb.velocity = new Vector2(0, _player.rb.velocity.y);
        }

        if (Input.GetKeyDown(KeyCode.W) && _player.IsClimbable())
        {
            _stateController.ChangeState(new Climb());
        }
    }

    public virtual void OnExit()
    {
        
    }
}
