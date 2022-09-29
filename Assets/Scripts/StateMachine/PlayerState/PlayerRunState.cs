using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


[CreateAssetMenu(menuName ="Data/Machine/State/Player/Run",fileName ="PlayerRunData")]
public class PlayerRunState : PlayerState
{

    [SerializeField] float speed =1f;

    [SerializeField] float accelerate = 15f;

    public override void Enter()
    {
        base.Enter();


        curSpeed = player.MoveSpeed;
    }

    public override void LogicUpdate()
    {
        if (!(input.Move))
        {
            machine.SwitchOn(typeof(PlayerIdleState));
        }

        if (input.Jump)
        {
            machine.SwitchOn(typeof(PlayerJumpState));
        }

        if (!player.isGround)
        {
            machine.SwitchOn(typeof(PlayerCoyodeState));
        }

        curSpeed = Mathf.MoveTowards(curSpeed, speed, accelerate * Time.deltaTime);
        
    }

    public override void FixUpdate()
    {
        player.Move(curSpeed);
    }

    public override void Exit()
    {
        
    }
}
