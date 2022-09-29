using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Machine/State/Player/Fall", fileName = "PlayerFallData")]
public class PlayerFallState : PlayerState
{
    [SerializeField] float moveSpeed = 3.0f;

    [SerializeField] AnimationCurve curve;

    public override void Enter()
    {
        base.Enter();
    }


    public override void LogicUpdate()
    {
        if (player.isGround)
        {
            machine.SwitchOn(typeof(PlayerLandState));
        }

        if (input.Jump)
        {
            if (player.canDoubleJump)
            {
                machine.SwitchOn(typeof(PlayerAirJumpState));
                return;
            }

            input.SetJumpBuffer();            
        }
    }

    public override void FixUpdate()
    {
        player.Move(moveSpeed);

        player.SetVelocityY(curve.Evaluate(StateDuration));
    }


}
