using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(menuName = "Data/Machine/State/Player/Defeat",fileName = "PlayerDefeatData")]
public class PlayerDefeatState : PlayerState
{
    [SerializeField] AudioClip[] defeatClip;
    [SerializeField] ParticleSystem VFX;

    public override void Enter()
    {
        base.Enter();
        int temp = Random.Range(0, defeatClip.Length);
        AudioManager.audioSource.PlayOneShot(defeatClip[temp]);
        Instantiate(VFX, player.transform.position, Quaternion.identity);
    }

    public override void LogicUpdate()
    {
        if (AnimationFinish)
        {
            machine.SwitchOn(typeof(PlayerFloatState));
        }
    }
}
