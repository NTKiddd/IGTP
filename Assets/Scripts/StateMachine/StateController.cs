using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateController : MonoBehaviour
{
    protected State currentState;
    protected Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Start()
    {
        ChangeState(new Idle());
    }

    void Update()
    {
        if (currentState != null)
        {
            currentState.OnExecute();
        }
    }
    
    public void ChangeState(State newState)
    {
        if (currentState != null)
        {
            if (currentState.GetType() == newState.GetType())
            {
                return;
            }
        }
        
        currentState?.OnExit();
        currentState = newState;
        currentState.Initialize(this, _player);
    }
}
