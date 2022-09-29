using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Machine/State/Player/Coyode", fileName = "PlayerCoyodeData")]
public class PlayerCoyodeState : PlayerState
{
    [SerializeField] float speed = 1f;

    [SerializeField] float fixedAirTime = 0.1f;

    public override void Enter()
    {
        base.Enter();
        player.SetGravity(false);
    }

    public override void LogicUpdate()
    {
        if (input.Jump)
        {
            machine.SwitchOn(typeof(PlayerJumpState));
        }

        if (StateDuration > fixedAirTime || !input.Move)
        {
            machine.SwitchOn(typeof(PlayerFallState));
        }

    }

    public override void FixUpdate()
    {
        player.Move(speed);
    }

    public override void Exit()
    {
        Debug.Log("ø™∆Ù÷ÿ¡¶");
        player.SetGravity(true);
    }
}
