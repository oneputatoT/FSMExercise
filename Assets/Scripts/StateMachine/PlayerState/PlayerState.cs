using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerState : ScriptableObject ,IState
{

    [SerializeField] string stateName;

    [SerializeField, Range(0f, 1f)] float animationDuration = 0.1f;

    int stateHash;

    float startTime;

    protected Animator aim;

    protected PlayerStateMachne machine;

    protected PlayerController player;

    protected PlayerInput input;

    protected float curSpeed;

    //判定动画时间是否完成
    protected bool AnimationFinish => StateDuration>=aim.GetCurrentAnimatorStateInfo(0).length;

    protected float StateDuration => Time.time - startTime;


    public void Initialize(Animator aim, PlayerInput input, PlayerController player, PlayerStateMachne machine)
    {
        this.aim = aim;
        this.input = input;
        this.player = player;
        this.machine = machine;
    }

    private void OnEnable()
    {
        stateHash = Animator.StringToHash(stateName);
    }

    public virtual void Enter()
    {
        aim.CrossFade(stateHash, animationDuration);
        startTime = Time.time;
    }

    public virtual void FixUpdate()
    {
        
    }

    public virtual void LogicUpdate()
    {
        
    }
    public virtual void Exit()
    {
        
    }
}
