using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Data/Machine/State/Player/Jump", fileName = "PlayerJumpData")]
public class PlayerJumpState : PlayerState
{

    [SerializeField] float moveSpeed = 5.0f;
    [SerializeField] float upSpeed = 1.0f;
    [SerializeField] ParticleSystem JumpVFX;
    [SerializeField] AudioClip[] clips;
    public override void Enter()
    {
        base.Enter();
        int temp = Random.Range(0, clips.Length);
        player.audioSource.PlayOneShot(clips[temp]);
        input.JumpBuffer = false;
        player.SetVelocityY(upSpeed);
        Instantiate(JumpVFX, player.transform.position, Quaternion.identity);
    }

    public override void LogicUpdate()
    {
        if (input.StopJump||player.isFall)
        {
            machine.SwitchOn(typeof(PlayerFallState));
        }
        
    }

    public override void FixUpdate()
    {
        player.Move(moveSpeed);
    }


}
