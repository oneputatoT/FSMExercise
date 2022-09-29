using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Machine/State/Player/AirJump", fileName = "PlayerAirJumpData")]
public class PlayerAirJumpState : PlayerState
{
    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float upSpeed = 1.0f;
    [SerializeField] ParticleSystem airJumpVFX;
    [SerializeField] AudioClip[] clips;

    public override void Enter()
    {
        base.Enter();
        int temp = Random.Range(0, clips.Length);
        player.audioSource.PlayOneShot(clips[temp]);
        player.SetVelocityY(upSpeed);
        Instantiate(airJumpVFX, player.transform.position, Quaternion.identity);
        player.canDoubleJump = false;
    }

    public override void LogicUpdate()
    {

        if (input.StopJump || player.isFall)
        {
            machine.SwitchOn(typeof(PlayerFallState));
        }

    }

    public override void FixUpdate()
    {
        player.Move(moveSpeed);
    }
}
