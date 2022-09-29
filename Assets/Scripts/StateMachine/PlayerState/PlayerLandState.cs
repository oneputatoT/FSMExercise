using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Machine/State/Player/Land", fileName = "PlayerLandData")]
public class PlayerLandState : PlayerState
{
    public override void Enter()
    {
        base.Enter();
        player.canDoubleJump = false;
        player.SetVelocity(Vector2.zero);
    }

    public override void LogicUpdate()
    {
        if (player.victory)
        {
            machine.SwitchOn(typeof(PlayerVictoryState));
        }

        if (input.Jump||input.JumpBuffer)
        {
            machine.SwitchOn(typeof(PlayerJumpState));
        }

        if (!AnimationFinish) return;

        if (input.Move)
        {
            machine.SwitchOn(typeof(PlayerRunState));
        }

        if (!input.Move)
        {
            machine.SwitchOn(typeof(PlayerIdleState));
        }

    }
}
