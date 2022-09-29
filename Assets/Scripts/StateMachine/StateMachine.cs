using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachine : MonoBehaviour
{
    protected IState curState;

    protected PlayerInput input;

    protected PlayerController player;

    public Dictionary<System.Type, IState> dic;

    protected virtual void Update()
    {
        curState.LogicUpdate();
    }

    protected virtual void FixedUpdate()
    {
        curState.FixUpdate();
    }

    public virtual void SwitchOn(IState nextState)
    {
        if (curState != null)
        {
            curState.Exit();
        }
        curState = nextState;
        curState.Enter();
    }

    public virtual void SwitchOn(System.Type nextState)
    {
        if (curState != null)
        {
            curState.Exit();
        }
        curState = dic[nextState];
        curState.Enter();
    }
}
