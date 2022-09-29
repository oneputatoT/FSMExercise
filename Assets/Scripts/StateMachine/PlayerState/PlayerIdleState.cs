using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "Data/Machine/State/Player/Idle", fileName = "PlayerIdleData")]
public class PlayerIdleState : PlayerState
{

    [SerializeField] float decelerate = 20f;


    public override void Enter()
    {

        base.Enter();

        curSpeed = player.MoveSpeed;
    }

    public override void LogicUpdate()
    {
        if (input.Move)
        {
            machine.SwitchOn(typeof(PlayerRunState));
        }

        if (input.Jump)
        {
            machine.SwitchOn(typeof(PlayerJumpState));
        }

        if (!player.isGround)
        {
            machine.SwitchOn(typeof(PlayerFallState));
        }

        curSpeed = Mathf.MoveTowards(curSpeed, 0, decelerate * Time.deltaTime);
    }

    public override void FixUpdate()
    {
        player.SetVelocityX(curSpeed * player.transform.localScale.x);
    }

    public override void Exit()
    {
        Debug.Log("到达最高点");
    }
}
